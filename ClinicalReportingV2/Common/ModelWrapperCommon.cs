using GalaSoft.MvvmLight;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
#pragma warning disable 693

namespace ClinicalReporting.Model.Wrapper
{
    public abstract class CommonWrapper<T> : ObservableObject, INotifyDataErrorInfo
    {
        private readonly Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();

        protected CommonWrapper(T model)
        {
            Model = model;
        }

        public T Model { get; }
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged = delegate { };

        public IEnumerable GetErrors(string propertyName)
        {
            if (_errors.ContainsKey(propertyName))
                return _errors[propertyName];
            return null;
        }

        public bool HasErrors => _errors.Count > 0;

        private void ValidateProperty<T>(string propertyName, T value)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this) { MemberName = propertyName };
            Validator.TryValidateProperty(value, context, results);
            if (results.Any())
                _errors[propertyName] = results.Select(c => c.ErrorMessage).ToList();
            else
                _errors.Remove(propertyName);
            ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
        }

        protected T GET<T>(ref T member, [CallerMemberName] string propertyName = null)
        {
            var propertyInfo = Model.GetType().GetProperty(propertyName);
            return member = (T)propertyInfo.GetValue(Model);
        }

        protected void SET<T>(ref T member, T value, [CallerMemberName] string propertyName = null)
        {
            var propertyInfo = Model.GetType().GetProperty(propertyName);
            var currentValue = propertyInfo.GetValue(Model);
            if (!Equals(currentValue, value))
            {
                propertyInfo.SetValue(Model, value);
                Set(ref member, value, propertyName);
                ValidateProperty(propertyName, value);
            }
        }

        protected void RegisterCollection<TWrapper, TModel>(ObservableCollection<TWrapper> wrapperCollection,
            List<TModel> modelCollection) where TWrapper : CommonWrapper<TModel>
        {
            wrapperCollection.CollectionChanged += (s, e) =>
                                                   {
                                                       if (e.OldItems != null)
                                                           foreach (var item in e.OldItems.Cast<TWrapper>())
                                                               modelCollection.Remove(item.Model);
                                                       if (e.NewItems != null)
                                                           foreach (var item in e.NewItems.Cast<TWrapper>())
                                                               modelCollection.Add(item.Model);
                                                   };
        }

        protected void RegisterComplex<TWrapper, TModel>(ref TWrapper wrapperComplex, ref TModel modelComplex)
            where TWrapper : CommonWrapper<TModel>
        {
            if (!Equals(wrapperComplex.Model, modelComplex))
                modelComplex = wrapperComplex.Model;
        }
    }
}
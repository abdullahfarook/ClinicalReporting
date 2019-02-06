using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Transactions;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace ClinicalReporting.Model.Repository
{
    #region Interface

    public interface IDoctorsRepository
    {
        IDbConnection Custom { get; }
        Task<Doctor> AddDoctorAsync(Doctor doctor);
        Task<List<Doctor>> GetAllDoctorAsync();
        Task<Doctor> FindDoctorAsync(long id);
        Task<Doctor> UpdateDoctorAsync(Doctor doctor);
        Task RemoveDoctorAsync(long id);
        Task<Doctor> GetDoctorWithChildrenAsync(long id);
        Task<Doctor> SaveDoctorAsync(Doctor doctor);
        Task<List<Doctor>> QueryAsync(string query);
        Doctor AddDoctor(Doctor doctor);
        List<Doctor> GetAllDoctor();
        Doctor FindDoctor(long id);
        Doctor UpdateDoctor(Doctor doctor);
        void RemoveDoctor(long id);
        Doctor GetWithChildren(long id);
        Doctor SaveDoctor(Doctor doctor);
        List<Doctor> Query(string query);
    }

    #endregion

    #region Original Repository

    public class DoctorRepository : IDoctorsRepository, IDisposable
    {
        private IDbConnectionFactory DbFactory { get; }
        private IDbConnection _conn;

        private IDbConnection Conn => _conn ?? (_conn = DbFactory.Open());

        public DoctorRepository(IDbConnectionFactory dbFactory)
        {
            DbFactory = dbFactory;
        }

        public Doctor AddDoctor(Doctor doctor)
        {
            Conn.Insert(doctor);
            doctor.DoctorID = Conn.LastInsertId();
            return doctor;
        }

        public List<Doctor> GetAllDoctor()
        {
            return Conn.Select<Doctor>();
        }

        public Doctor FindDoctor(long id)
        {
            return Conn.SingleById<Doctor>(id);
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            var result = Conn.Update(doctor);
            return doctor;
        }

        public void RemoveDoctor(long id)
        {
            Conn.DeleteById<Doctor>(id);
        }

        public Doctor GetWithChildren(long id)
        {
            var doctor = Conn.SingleById<Doctor>(id);
            return doctor;
        }

        public Doctor SaveDoctor(Doctor doctor)
        {
            using (var txScope = new TransactionScope())
            {
                if (doctor.IsNew)
                    AddDoctor(doctor);
                else
                    UpdateDoctor(doctor);
                txScope.Complete();
            }
            return doctor;
        }

        public List<Doctor> Query(string query)
        {
            return Conn.Select<Doctor>(query);
        }

        #endregion

        #region Asyn Methods

        public async Task<Doctor> AddDoctorAsync(Doctor doctor)
        {
            await Conn.InsertAsync(doctor);
            doctor.DoctorID = Conn.LastInsertId();
            return doctor;
        }

        public async Task<List<Doctor>> GetAllDoctorAsync()
        {
            return await Conn.SelectAsync<Doctor>();
        }

        public async Task<Doctor> FindDoctorAsync(long id)
        {
            return await Conn.SingleByIdAsync<Doctor>(id);
        }

        public async Task<Doctor> UpdateDoctorAsync(Doctor doctor)
        {
            await Conn.UpdateAsync(doctor);
            return doctor;
        }

        public async Task RemoveDoctorAsync(long id)
        {
            await Conn.DeleteByIdAsync<Doctor>(id);
        }

        public async Task<Doctor> GetDoctorWithChildrenAsync(long id)
        {
            var doctor = await Conn.SingleByIdAsync<Doctor>(id);
            return doctor;
        }

        public async Task<Doctor> SaveDoctorAsync(Doctor doctor)
        {
            using (var txScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                if (doctor.IsNew)
                    await AddDoctorAsync(doctor);
                else
                    await UpdateDoctorAsync(doctor);
                txScope.Complete();
            }
            return doctor;
        }

        public async Task<List<Doctor>> QueryAsync(string query)
        {
            return await Conn.SelectAsync<Doctor>(query);
        }

        #endregion

        #region Design Repository

        public IDbConnection Custom => Conn;

        public void Dispose()
        {
            if (Conn != null)
                Conn.Dispose();
        }
    }

    public class DesignDoctorsRepository : IDoctorsRepository
    {
        public Doctor AddDoctor(Doctor doctor)
        {
            return null;
        }

        public List<Doctor> GetAllDoctor()
        {
            var resultList = new List<Doctor>();
            for (var i = 0; i < 10; i++)
                resultList.Add(new Doctor
                {
                    DoctorID = i + 12345,
                    DoctorName = "DoctorName" + i
                });
            return resultList;
        }

        public Doctor FindDoctor(long id)
        {
            return new Doctor
            {
                DoctorID = 12345,
                DoctorName = "DoctorName"
            };
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            return null;
        }

        public void RemoveDoctor(long id)
        {
        }

        public Doctor GetWithChildren(long id)
        {
            return new Doctor
            {
                DoctorID = 12345,
                DoctorName = "DoctorName"
            };
        }

        public Doctor SaveDoctor(Doctor doctor)
        {
            return null;
        }

        public List<Doctor> Query(string query)
        {
            var resultList = new List<Doctor>();
            for (var i = 0; i < 10; i++)
                resultList.Add(new Doctor
                {
                    DoctorID = i + 12345,
                    DoctorName = "DoctorName" + i
                });
            return resultList;
        }

        public async Task<Doctor> AddDoctorAsync(Doctor doctor)
        {
            return await Task.Run(() => new Doctor());
        }

        public async Task<List<Doctor>> GetAllDoctorAsync()
        {

            return await Task.Run(() =>
                      {
                          var resultList = new List<Doctor>();
                          for (var i = 0; i < 10; i++)
                              resultList.Add(new Doctor
                              {
                                  DoctorID = i + 12345,
                                  DoctorName = "DoctorName" + i
                              });
                          return resultList;
                      });

        }

        public async Task<Doctor> FindDoctorAsync(long id)
        {
            return new Doctor
            {
                DoctorID = 12345,
                DoctorName = "DoctorName"
            };
        }

        public async Task<Doctor> UpdateDoctorAsync(Doctor doctor)
        {
            return null;
        }

        public async Task RemoveDoctorAsync(long id)
        {
        }

        public async Task<Doctor> GetDoctorWithChildrenAsync(long id)
        {
            return new Doctor
            {
                DoctorID = 12345,
                DoctorName = "DoctorName"
            };
        }

        public async Task<Doctor> SaveDoctorAsync(Doctor doctor)
        {
            return null;
        }

        public async Task<List<Doctor>> QueryAsync(string query)
        {
            var resultList = new List<Doctor>();
            for (var i = 0; i < 10; i++)
                resultList.Add(new Doctor
                {
                    DoctorID = i + 12345,
                    DoctorName = "DoctorName" + i
                });
            return resultList;
        }

        public IDbConnection Custom => null;
    }

    #endregion
}
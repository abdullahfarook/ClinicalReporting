using ClinicalReporting.Common;
using ClinicalReporting.Model;
using ClinicalReporting.Model.Wrapper;

namespace ClinicalReporting.ViewModel
{
    public class UrineExaminationTestVM : ViewModelCommon, ITest
    {
        private UrineExaminationW _urineexaminationw;

        public UrineExaminationTestVM(IModelCommon urineexamination)
        {
            _urineexaminationw = new UrineExaminationW(urineexamination as UrineExamination);
        }

        public UrineExaminationTestVM()
        {
            _urineexaminationw = new UrineExaminationW(new UrineExamination());
        }

        public UrineExaminationW UrineExamination
        {
            get => _urineexaminationw;
            set { Set(() => UrineExamination, ref _urineexaminationw, value); }
        }
    }
}
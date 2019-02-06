using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace ClinicalReporting.Model.Repository
{
    #region Interface

    public interface IElisaHcvsRepository
    {
        IDbConnection Custom { get; }
        Task<ElisaHcv> AddElisaHcvAsync(ElisaHcv elisahcv);
        Task<List<ElisaHcv>> GetAllElisaHcvAsync();
        Task<ElisaHcv> FindElisaHcvAsync(long id);
        Task<ElisaHcv> UpdateElisaHcvAsync(ElisaHcv elisahcv);
        Task RemoveElisaHcvAsync(long id);
        Task<ElisaHcv> GetElisaHcvWithChildrenAsync(long id);
        Task<ElisaHcv> SaveElisaHcvAsync(ElisaHcv elisahcv);
        Task<List<ElisaHcv>> QueryAsync(string query);
        ElisaHcv AddElisaHcv(ElisaHcv elisahcv);
        List<ElisaHcv> GetAllElisaHcv();
        ElisaHcv FindElisaHcv(long id);
        ElisaHcv UpdateElisaHcv(ElisaHcv elisahcv);
        void RemoveElisaHcv(long id);
        ElisaHcv GetWithChildren(long id);
        ElisaHcv SaveElisaHcv(ElisaHcv elisahcv);
        List<ElisaHcv> Query(string query);
    }

    #endregion

    #region Original Repository

    public class ElisaHcvRepository : IElisaHcvsRepository, IDisposable
    {
        private IDbConnectionFactory DbFactory { get; }
        private IDbConnection _conn;

        private IDbConnection Conn => _conn ?? (_conn = DbFactory.Open());

        public ElisaHcvRepository(IDbConnectionFactory dbFactory)
        {
            DbFactory = dbFactory;
        }

        public ElisaHcv AddElisaHcv(ElisaHcv elisahcv)
        {
            Conn.Insert(elisahcv);
            elisahcv.SerialNo = Conn.LastInsertId();
            return elisahcv;
        }

        public List<ElisaHcv> GetAllElisaHcv()
        {
            return Conn.Select<ElisaHcv>();
        }

        public ElisaHcv FindElisaHcv(long id)
        {
            return Conn.SingleById<ElisaHcv>(id);
        }

        public ElisaHcv UpdateElisaHcv(ElisaHcv elisahcv)
        {
            var result = Conn.Update(elisahcv);
            return elisahcv;
        }

        public void RemoveElisaHcv(long id)
        {
            Conn.DeleteById<ElisaHcv>(id);
        }

        public ElisaHcv GetWithChildren(long id)
        {
            var elisahcv = Conn.SingleById<ElisaHcv>(id);
            // One To One 
            var patient = Conn.Select<Patient>().Where(a => a.PatientID == id).SingleOrDefault();
            if (elisahcv != null && patient != null)
                elisahcv.Patient = patient;
            return elisahcv;
        }

        public ElisaHcv SaveElisaHcv(ElisaHcv elisahcv)
        {
            using (var txScope = new TransactionScope())
            {
                if (elisahcv.IsNew)
                    AddElisaHcv(elisahcv);
                else
                    UpdateElisaHcv(elisahcv);
                // One To One 
                if (elisahcv.Patient != null)
                {
                    var patient = elisahcv.Patient;
                    patient.PatientID = elisahcv.SerialNo;
                    Conn.Save(patient);
                }
                txScope.Complete();
            }
            return elisahcv;
        }

        public List<ElisaHcv> Query(string query)
        {
            return Conn.Select<ElisaHcv>(query);
        }

        #endregion

        #region Asyn Methods

        public async Task<ElisaHcv> AddElisaHcvAsync(ElisaHcv elisahcv)
        {
            await Conn.InsertAsync(elisahcv);
            elisahcv.SerialNo = Conn.LastInsertId();
            return elisahcv;
        }

        public async Task<List<ElisaHcv>> GetAllElisaHcvAsync()
        {
            return await Conn.SelectAsync<ElisaHcv>();
        }

        public async Task<ElisaHcv> FindElisaHcvAsync(long id)
        {
            return await Conn.SingleByIdAsync<ElisaHcv>(id);
        }

        public async Task<ElisaHcv> UpdateElisaHcvAsync(ElisaHcv elisahcv)
        {
            await Conn.UpdateAsync(elisahcv);
            return elisahcv;
        }

        public async Task RemoveElisaHcvAsync(long id)
        {
            await Conn.DeleteByIdAsync<ElisaHcv>(id);
        }

        public async Task<ElisaHcv> GetElisaHcvWithChildrenAsync(long id)
        {
            var elisahcv = await Conn.SingleByIdAsync<ElisaHcv>(id);
            // One To One 
            var patient = await Conn.SingleAsync<Patient>(e => e.PatientID == id);
            if (elisahcv != null && patient != null)
                elisahcv.Patient = patient;
            return elisahcv;
        }

        public async Task<ElisaHcv> SaveElisaHcvAsync(ElisaHcv elisahcv)
        {
            using (var txScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                if (elisahcv.IsNew)
                    await AddElisaHcvAsync(elisahcv);
                else
                    await UpdateElisaHcvAsync(elisahcv);
                // One To One 
                if (elisahcv.Patient != null)
                    if (elisahcv.Patient.IsDeleted)
                    {
                        var id = elisahcv.Patient.PatientID;
                        await Conn.DeleteByIdAsync<Patient>(id);
                    }
                    else if (!elisahcv.Patient.IsDeleted)
                    {
                        var patient = elisahcv.Patient;
                        patient.PatientID = elisahcv.SerialNo;
                        await Conn.SaveAsync(patient);
                    }
                txScope.Complete();
            }
            return elisahcv;
        }

        public async Task<List<ElisaHcv>> QueryAsync(string query)
        {
            return await Conn.SelectAsync<ElisaHcv>(query);
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

    public class DesignElisaHcvsRepository : IElisaHcvsRepository
    {
        public ElisaHcv AddElisaHcv(ElisaHcv elisahcv)
        {
            return null;
        }

        public List<ElisaHcv> GetAllElisaHcv()
        {
            var resultList = new List<ElisaHcv>();
            for (var i = 0; i < 10; i++)
                resultList.Add(new ElisaHcv
                               {
                                   SerialNo = i + 12345,
                                   PatientID = i + 12345,
                                   TDate = DateTime.Now,
                                   PatientValue = i + 12345,
                                   CutOffValue = i + 12345,
                                   Fee = i + 12345
                               });
            return resultList;
        }

        public ElisaHcv FindElisaHcv(long id)
        {
            return new ElisaHcv
                   {
                       SerialNo = 12345,
                       PatientID = 12345,
                       TDate = DateTime.Now,
                       PatientValue = 12345,
                       CutOffValue = 12345,
                       Fee = 12345
                   };
        }

        public ElisaHcv UpdateElisaHcv(ElisaHcv elisahcv)
        {
            return null;
        }

        public void RemoveElisaHcv(long id)
        {
        }

        public ElisaHcv GetWithChildren(long id)
        {
            //One to One
            var patient = new Patient
                          {
                              PatientID = 12345,
                              Name = "Name",
                              Age = "Age",
                              Sex = "Sex",
                              RefBy = "RefBy"
                          };
            return new ElisaHcv
                   {
                       SerialNo = 12345,
                       PatientID = 12345,
                       TDate = DateTime.Now,
                       PatientValue = 12345,
                       CutOffValue = 12345,
                       Fee = 12345,
                       //One to One
                       Patient = patient
                   };
        }

        public ElisaHcv SaveElisaHcv(ElisaHcv elisahcv)
        {
            return null;
        }

        public List<ElisaHcv> Query(string query)
        {
            var resultList = new List<ElisaHcv>();
            for (var i = 0; i < 10; i++)
                resultList.Add(new ElisaHcv
                               {
                                   SerialNo = i + 12345,
                                   PatientID = i + 12345,
                                   TDate = DateTime.Now,
                                   PatientValue = i + 12345,
                                   CutOffValue = i + 12345,
                                   Fee = i + 12345
                               });
            return resultList;
        }

        public Task<ElisaHcv> AddElisaHcvAsync(ElisaHcv elisahcv)
        {
            return null;
        }

        public async Task<List<ElisaHcv>> GetAllElisaHcvAsync()
        {
            var resultList = new List<ElisaHcv>();
            for (var i = 0; i < 10; i++)
                resultList.Add(new ElisaHcv
                               {
                                   SerialNo = i + 12345,
                                   PatientID = i + 12345,
                                   TDate = DateTime.Now,
                                   PatientValue = i + 12345,
                                   CutOffValue = i + 12345,
                                   Fee = i + 12345
                               });
            return resultList;
        }

        public async Task<ElisaHcv> FindElisaHcvAsync(long id)
        {
            return new ElisaHcv
                   {
                       SerialNo = 12345,
                       PatientID = 12345,
                       TDate = DateTime.Now,
                       PatientValue = 12345,
                       CutOffValue = 12345,
                       Fee = 12345
                   };
        }

        public async Task<ElisaHcv> UpdateElisaHcvAsync(ElisaHcv elisahcv)
        {
            return null;
        }

        public async Task RemoveElisaHcvAsync(long id)
        {
        }

        public async Task<ElisaHcv> GetElisaHcvWithChildrenAsync(long id)
        {
            //One to One
            var patient = new Patient
                          {
                              PatientID = 12345,
                              Name = "Name",
                              Age = "Age",
                              Sex = "Sex",
                              RefBy = "RefBy"
                          };
            return new ElisaHcv
                   {
                       SerialNo = 12345,
                       PatientID = 12345,
                       TDate = DateTime.Now,
                       PatientValue = 12345,
                       CutOffValue = 12345,
                       Fee = 12345,
                       //One to One
                       Patient = patient
                   };
        }

        public async Task<ElisaHcv> SaveElisaHcvAsync(ElisaHcv elisahcv)
        {
            return null;
        }

        public async Task<List<ElisaHcv>> QueryAsync(string query)
        {
            var resultList = new List<ElisaHcv>();
            for (var i = 0; i < 10; i++)
                resultList.Add(new ElisaHcv
                               {
                                   SerialNo = i + 12345,
                                   PatientID = i + 12345,
                                   TDate = DateTime.Now,
                                   PatientValue = i + 12345,
                                   CutOffValue = i + 12345,
                                   Fee = i + 12345
                               });
            return resultList;
        }

        public IDbConnection Custom => null;
    }

    #endregion
}
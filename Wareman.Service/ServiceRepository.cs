using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wareman.Service
{
    public class ServiceRepository: IServiceRepository
    {
         private WMDBDEMOEntities _ctx;
         public ServiceRepository(WMDBDEMOEntities ctx)
         {
            _ctx = ctx;
         }

         #region PO Methods
         public IQueryable<PO_Header> GetAllPOs()
         {
            return _ctx.PO_Header
                    .AsQueryable();
         }
         public IQueryable<PO_Header> GetPOByNumber(string poNumber)
         {
             return _ctx.PO_Header
                     .Include("PO_Detail")
                     .Where(c => c.PO_Detail.Any(s => s.PONumber == poNumber))
                     .AsQueryable();
         }
        public PO_Header GetPO(string companyID, string poNumber)
        {
            return _ctx.PO_Header.Find(companyID,poNumber);
        }

        public PO_Header GetPO(string poNumber, bool includeDetails = true)
        {

            if (includeDetails)
            {
                return _ctx.PO_Header
                    .Include("PO_Detail")
                   .Where(c => c.PONumber == poNumber)
                   .SingleOrDefault();
            }
            else
            {
                return _ctx.PO_Header
                       .Where(c => c.PONumber == poNumber)
                       .SingleOrDefault();
            }
        }

        public IQueryable<PO_Header> GetPOWithDetails(string poNumber)
        {
            return _ctx.PO_Header
                    .Include("PO_Detail")
                    .Where(c => c.PONumber == poNumber)
                    .AsQueryable();
        }
        public bool POExists(string poNumber)
        {
            return _ctx.PO_Header.Any(c => c.PONumber == poNumber);
        }
     #endregion

         #region Requisition Methods
        public IQueryable<PT_RequisitionHeader> GetAllRequisitions()
        {
            return _ctx.PT_RequisitionHeader
                    .AsQueryable();
        }

        public PO_Header GetRequisition(string companyID, string reqNumber)
        {
            return _ctx.PO_Header.Find(companyID, reqNumber);
        }
        public PT_RequisitionHeader GetRequisition(string reqNumber, bool includeDetails = true)
        {

            if (includeDetails)
            {
                return _ctx.PT_RequisitionHeader
                    .Include("PT_RequisitionDetail")
                   .Where(c => c.PONumber == reqNumber)
                   .SingleOrDefault();
            }
            else
            {
                return _ctx.PT_RequisitionHeader
                       .Where(c => c.RequisitionNumber == reqNumber)
                       .SingleOrDefault();
            }
        }

        public IQueryable<PT_RequisitionHeader> GetRequisitionWithDetails(string reqNumber)
        {
            return _ctx.PT_RequisitionHeader
                    .Include("PT_RequisitionDetail")
                    .Where(c => c.RequisitionNumber == reqNumber)
                    .AsQueryable();
        }

        public bool RequisitionExists(string reqNumber)
        {
            return _ctx.PT_RequisitionHeader.Any(c => c.RequisitionNumber == reqNumber);
        }

        #endregion

        #region
        public IQueryable<PT_Parts> GetAllParts()
        {
            return _ctx.PT_Parts
                    .AsQueryable();
        }

        public PT_Parts GetPart(string companyID, string partNo)
        {
            return _ctx.PT_Parts.Find(companyID, partNo);
        }

        public PT_Parts GetPart(string productCode, string partNo, string referenceNo)
        {
            if (string.IsNullOrEmpty(productCode) && string.IsNullOrEmpty(referenceNo))
            {
                return _ctx.PT_Parts
                   .Where(c => c.PartNumber == partNo)
                   .SingleOrDefault();
            }
            else if (string.IsNullOrEmpty(referenceNo))
            {
                return _ctx.PT_Parts
                    .Where(c => c.ProductCode == productCode && c.PartNumber == partNo)
                    .SingleOrDefault();
            }
            else
            {
                return _ctx.PT_Parts
                  .Where(c => c.ProductCode == productCode)
                  .SingleOrDefault();
            }
        }

        public bool PartExists(string partNo)
        {
            return _ctx.PT_Parts.Any(c => c.PartNumber == partNo);
        }
        #endregion
   

       

        //public int EnrollStudentInCourse(int studentId, int courseId, Enrollment enrolment)
        //{
        //    try
        //    {
        //        if (_ctx.Enrollments.Any(e => e.Course.Id == courseId && e.Student.Id == studentId))
        //        {
        //            return 2;
        //        }

        //        _ctx.Database.ExecuteSqlCommand("INSERT INTO Enrollments VALUES (@p0, @p1, @p2)",
        //            enrolment.EnrollmentDate, courseId.ToString(), studentId.ToString());

        //        return 1;
        //    }
        //    catch (System.Data.Entity.Validation.DbEntityValidationException dbex)
        //    {
        //        foreach (var eve in dbex.EntityValidationErrors)
        //        {
        //            string line = string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
        //                eve.Entry.Entity.GetType().Name, eve.Entry.State);

        //            foreach (var ve in eve.ValidationErrors)
        //            {
        //                line = string.Format("- Property: \"{0}\", Error: \"{1}\"",
        //                    ve.PropertyName, ve.ErrorMessage);

        //            }
        //        }
        //        return 0;

        //    }
        //    catch (Exception ex)
        //    {
        //        return 0;
        //    }
        //}

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }

        public bool LoginClient(string userName, string password)
        {
            var client = _ctx.PayEmployees.Where(s => s.EmployeeUserName == userName).SingleOrDefault();

            if (client != null)
            {
                if (client.EmployeePassword == password)
                {
                    return true;
                }
            }

            return false;
        }

    }
}

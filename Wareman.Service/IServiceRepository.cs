using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wareman.Service
{
     public interface IServiceRepository
     {
         IQueryable<PT_Parts> GetAllParts();
         IQueryable<PO_Header> GetAllPOs();
         IQueryable<PT_RequisitionHeader> GetAllRequisitions();
         PT_Parts GetPart(string companyID, string partNo);
         PT_Parts GetPart(string productCode, string partNo, string referenceNo);
         PO_Header GetPO(string companyID, string poNumber);
         PO_Header GetPO(string poNumber, bool includeDetails = true);
         IQueryable<PO_Header> GetPOByNumber(string poNumber);
         System.Linq.IQueryable<PO_Header> GetPOWithDetails(string poNumber);
         PO_Header GetRequisition(string companyID, string reqNumber);
         PT_RequisitionHeader GetRequisition(string reqNumber, bool includeDetails = true);
         IQueryable<PT_RequisitionHeader> GetRequisitionWithDetails(string reqNumber);
         bool PartExists(string partNo);
         bool POExists(string poNumber);
         bool RequisitionExists(string reqNumber);
         bool LoginClient(string userName, string password);
         bool SaveAll();
    }
}

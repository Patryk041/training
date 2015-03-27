using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Koziu.Departure.Helpers
{

     public  class CheckStatusHelper
     {
         
         private const int maxDay = 7; 
         
         public static bool CheckStatus(KoziuDepartureEntity entity, KoziuDepartureList departureList)
         {    
             switch (entity.StatusId)
             {
                 case 1:
                     return IsActive(entity);
                 case 2: 
                     return IsDeparturing(entity);
                 case 3:
                     return IsExperienced(entity, departureList);
                 case 4:
                     return IsInadequate(entity, departureList);
                 case 5:
                     return IsNew(entity, departureList);
                 case 6:
                     return IsRevisiting(entity, departureList);
                 default  :
                     return false;  
             }   
         }     
         

         private static bool IsActive(KoziuDepartureEntity entity)
         {
             return (entity.DepartureDate < DateTime.Now && entity.DepartureDate > DateTime.Now);
         }

         private static bool IsDeparturing(KoziuDepartureEntity entity)
         {
             return (entity.DepartureDate <= DateTime.Now.AddDays(maxDay) && entity.DepartureDate > DateTime.Now);
         }

         private static bool IsExperienced(KoziuDepartureEntity entity, KoziuDepartureList departureList)
         {
             var result = false;
             foreach (var value in departureList)
             {
                  result = (value.ClientId == entity.ClientId && (entity.ReturnDate < DateTime.Now));
             }
             return result;
         }
         private static bool IsInadequate(KoziuDepartureEntity entity, KoziuDepartureList departureList)
         {
             var result = false;
             foreach (var value in departureList)
             {
                 result = (entity.ReturnDate > DateTime.Now);
             }
             return result;
         }
         private static bool IsNew(KoziuDepartureEntity entity, KoziuDepartureList departureList)
         {
             var result = false;
             foreach (var value in departureList)
             {
                 if (value.ClientId != entity.ClientId && (entity.DepartureDate.AddDays(-(maxDay)) < DateTime.Now)) result = true;
             }
             return result;
         }
         private static bool IsRevisiting(KoziuDepartureEntity entity, KoziuDepartureList departureList)
         {      
             var result = false;
             foreach (var value in departureList)
             {
                 if(value.ClientId == 3 && (entity.DepartureDate.AddDays(-(maxDay)) < DateTime.Now)) result = true;   
             }       
             return result;
         }
                       

        

         

       

        


    }
}

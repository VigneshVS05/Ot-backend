using Microsoft.AspNetCore.Mvc;
using OTRate.Models;
namespace OTRate.Controllers;

[ApiController]
[Route("api/Welcome")]
public class OTRateController : ControllerBase
{
    private readonly OtrateContext DB;

    public OTRateController(OtrateContext db)
    {
        this.DB = db;

    }
     [HttpGet("GetAllOT")]
    public IQueryable<OtRateDef> GetAllOT()

    {
        try{
            return DB.OtRateDefs;
        }
        catch(System.Exception)
        {
            throw;
        }
    }
  [HttpPost("InsertOT")]
 public object InsertOT(OTRateReg regObj)
    {
        string message="";
        try{
           OtRateDef e2 =new OtRateDef();
            if(e2.Id==0){
                e2.Id=regObj.RegId;
                e2.OtSlabName=regObj.RegOTSlabName;
                e2.OtSlabType=regObj.RegOTSlabType;
                 e2.PayGroup=regObj.RegPayGroup;
                  e2.HrsComponent=regObj.RegHrsComponet;
                   e2.OtValueComponent=regObj.RegOTValueComponent;
                  e2.BaseComponent=regObj.RegBaseComponent;
                  e2.OtRate=regObj.RegOTRate;
                  e2.ConsiderForOt=regObj.RegConsiderforOT;
                  e2.MonthlyRate=regObj.RegMonthlyRate;
                  e2.StartDate=regObj.RegStartDate;
                  e2.EndDate=regObj.RegEndDate;
                 


                DB.OtRateDefs.Add(e2);
               int result = this.DB.SaveChanges();
                    if (result > 0)
                    {
                        message = "User has been sucessfully added";
                    }
                    else
                    {
                        message = "failed";
                    }

                     return Ok(message);
            //Add

            //save it in the database
            DB.SaveChanges();

            return new Response{Status="Success" , Message = "Employee Added!"};

        }
    }
    catch(System.Exception)
    {
throw;
    }

    return new Response{Status="Error" , Message="Invalid Information"};
  }

               


[HttpGet("GetUserDetailsById/{uid}")]
    public IActionResult GetByID(int uid)
    {
            var users =this.DB.OtRateDefs.FirstOrDefault(o=>o.Id==uid);
            return Ok(users);
    }

     [HttpDelete("DeleteUserDetails/{uid}")]
    public IActionResult DeleteUser(int uid)
    {
        string message = "";
            var user = this.DB.OtRateDefs.Find(uid);
            if (user == null)
            {
                return NotFound();
            }

            this.DB.OtRateDefs.Remove(user);
            int result = this.DB.SaveChanges();
            if (result > 0)
            {
                message = "User has been sussfully deleted";
            }
            else
            {
                message = "failed";
            }

            return Ok(message);
        }

}
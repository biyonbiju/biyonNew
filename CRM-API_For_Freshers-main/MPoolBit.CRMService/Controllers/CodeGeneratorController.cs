using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MPoolBit.CRMService.Models;

namespace MPoolBit.CRMService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeGeneratorController : ControllerBase
    {
        private readonly worldstar_newContext DBContext;
        public CodeGeneratorController(worldstar_newContext context)
        {
            this.DBContext = context;
        }
        public CodeGenerator Get(long? BranchId, long GeneratorModuleId)
        {
            var usercode = DBContext.CodeGenerator.Where(x => x.BranchId == BranchId && x.CodeGeneratorModuleId == GeneratorModuleId).FirstOrDefault();
            usercode.LatestCode += 1;
            var updatedcode = DBContext.CodeGenerator.Update(usercode);
            DBContext.SaveChanges();
            return updatedcode.Entity;
        }
    }
}
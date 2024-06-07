using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum AccessNiveau
    {
        None = 0,
        Reader = 100,
        BuildingValidator = 200,
        Administrator = 500,
        SuperAdministrator = 1000,
        Owner = 2000
    }
}

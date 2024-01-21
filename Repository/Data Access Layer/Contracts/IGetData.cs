using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data_Access_Layer.Contracts
{
    public interface IGetData
    {
        List<StudentsModel> GetStudentsData();
    }
}

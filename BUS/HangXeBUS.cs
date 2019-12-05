using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HangXeBUS
    {
        public static List<HangXeDTO> LayDS()
        {
            return DAO.HangXeDAO.LayDS();
        }
    }
}

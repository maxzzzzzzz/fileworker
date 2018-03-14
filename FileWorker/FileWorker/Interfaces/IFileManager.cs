using System;
using System.Collections.Generic;
using Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FileWorker.Interfaces
{
    public interface IFileManager
    {
        List<Person> ReadPersonFromFile(string pathFile);
        List<Unit> ReadUnitsFromFile(string pathName);
        List<Order> ReadOrdersFromFile(string pathName);
    }
}

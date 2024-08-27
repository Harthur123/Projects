using MySolution.Commons.valueobjects;
using MySolution.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolution.Domain.contracts
{
    public interface IContaBancariaRepositor
    {


        Task<IEnumerable<ContaBancaria>> GetList();

        Task Add(ContaBancaria ContaBancaria);

        Task Updater(ContaBancaria ContaBancaria);

        void Remove(ContaBancaria ContaBancaria);

    }
}

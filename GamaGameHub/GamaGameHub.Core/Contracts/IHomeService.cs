using GamaGameHub.Core.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamaGameHub.Core.Contracts
{
    public interface IHomeService
    {
        public void ContactUs(ContactUsViewModel viewModel);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MilenaApp.Services.Interface
{
    public interface IBackgroundEmailSender
    {
        Task DoWork();
    }
}

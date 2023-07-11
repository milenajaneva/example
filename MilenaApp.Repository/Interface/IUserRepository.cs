using MilenaApp.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilenaApp.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<MilenaAppUser> GetAll();
        MilenaAppUser Get(string id);
        void Insert(MilenaAppUser entity);
        void Update(MilenaAppUser entity);
        void Delete(MilenaAppUser entity);
    }
}
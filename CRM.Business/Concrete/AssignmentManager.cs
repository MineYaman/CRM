using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class AssignmentManager : IAssignmentService
    {
        private IAssingmentDal _AssingmentDal;

        public AssignmentManager(IAssingmentDal AssingmentDal)
        {
            _AssingmentDal = AssingmentDal;
        }

        public void Create(Assignment entity)
        {
            _AssingmentDal.Create(entity);
        }

        public void Delete(Assignment entity)
        {
            _AssingmentDal.Delete(entity);
        }

        public List<Assignment> GetAll()
        {
            return _AssingmentDal.GetAll().ToList();
        }

        public Assignment GetById(int id)
        {
            return _AssingmentDal.GetById(id);
        }

        public void Update(Assignment entity)
        {
            _AssingmentDal.Update(entity);
        }
    }
}

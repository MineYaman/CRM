using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class StateManager : IStateService
    {
        private IStateDal _StateDal;

        public StateManager(IStateDal StateDal)
        {
            _StateDal = StateDal;
        }

        public void Create(State entity)
        {
            _StateDal.Create(entity);
        }

        public void Delete(State entity)
        {
            _StateDal.Delete(entity);
        }

        public List<State> GetAll()
        {
            return _StateDal.GetAll().ToList();
        }

        public State GetById(int id)
        {
            return _StateDal.GetById(id);
        }

        public void Update(State entity)
        {
            _StateDal.Update(entity);
        }
    }
}

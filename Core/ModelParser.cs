using System;
using Core.Model;
using SelectFew.models;

namespace Core
{
    internal class ModelParser
    {
        public ModelParser()
        {
        }

        internal DataState Parse(DataSet data)
        {
            DataState state = new DataState();
            state.RidesMap = new Map(data);


            return state;
        }
    }
}
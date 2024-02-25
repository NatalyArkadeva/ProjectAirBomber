using ProjectAirBomber.CollectionGenericObjects;
using ProjectAirBomber.Drawnings;
using ProjectAirBomber.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirBomber.Database
{
    public interface ICollectionRepository
    {
        void Insert(string collectionName, CollectionType collectionType);
        void AddAirplane(string? collectionName, DrawningAirplane airplane);
        void RemoveAirplane(string? collectionName, DrawningAirplane airplane);
        void Delete(string collectionName);
    }
}

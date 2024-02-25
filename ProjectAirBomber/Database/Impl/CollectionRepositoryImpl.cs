using Microsoft.EntityFrameworkCore;
using ProjectAirBomber.CollectionGenericObjects;
using ProjectAirBomber.Drawnings;
using ProjectAirBomber.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirBomber.Database.Impl
{
    internal class CollectionRepositoryImpl : ICollectionRepository
    {
        public void AddAirplane(string? collectionName, DrawningAirplane airplane)
        {
            if (collectionName != null && airplane.EntityAirplane != null)
            {
                using (AirplaneContext db = new AirplaneContext())
                {
                    var collectionInfo = db.Collections.First(x => collectionName == x.Name);
                    airplane.EntityAirplane.CollectionInfoName = collectionName;
                    airplane.EntityAirplane.Collection = collectionInfo;

                    if(airplane.EntityAirplane is EntityAirplane)
                    {
                        db.Airplanes.Add(airplane.EntityAirplane);
                    }
                    if (airplane.EntityAirplane is EntityAirBomber)
                    {
                        db.AirBombers.Add((EntityAirBomber)airplane.EntityAirplane);
                    }
                    db.SaveChanges();

                    collectionInfo?.Airplanes.Add(airplane.EntityAirplane);
                    db.SaveChanges();
                }
            }
        }

        public void Delete(string collectionName)
        {
            using (AirplaneContext db = new AirplaneContext())
            {
                if (collectionName != null)
                {
                    var collectionInfo = db.Collections.First(x => collectionName.Equals(x.Name));
                    db.Collections.Remove(collectionInfo);
                    db.SaveChanges();
                }
            }
        }

        public void Insert(string collectionName, CollectionType collectionType)
        {
            using (AirplaneContext db = new AirplaneContext())
            {
                if (collectionName != null)
                {
                    var collectionInfo = new CollectionInfo(collectionName, collectionType, "");
                    db.Collections.Add(collectionInfo);
                    db.SaveChanges();
                }
            }
        }

        public void RemoveAirplane(string? collectionName, DrawningAirplane airplane)
        {
            if (collectionName != null && airplane.EntityAirplane != null)
            {
                using (AirplaneContext db = new AirplaneContext())
                {
                    var collectionInfo = db.Collections.First(x => collectionName.Equals(x.Name));
                    airplane.EntityAirplane.CollectionInfoName = collectionName;
                    airplane.EntityAirplane.Collection = collectionInfo;
                    collectionInfo?.Airplanes.Remove(airplane.EntityAirplane);
                    db.SaveChanges();
                }
            }
        }
    }
}

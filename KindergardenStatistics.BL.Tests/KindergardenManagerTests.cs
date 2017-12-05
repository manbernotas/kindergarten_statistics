using KindergardenStatistics.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KindergardenStatistics.BL.Tests
{
    [TestClass]
    public class KindergardenManagerTests
    {
        public Kindergarden Kindergarden = new Kindergarden()
        {
            Id = 1,
            Name = "Aitvaras",
            Groups = new List<Group>()
            {
                new Group()
                {
                    Id = 1,
                    Name = "VIJURKAI (ALERG.)",
                    KindergardenId = 1,
                    Children  = new List<Child>()
                    {
                        new Child()
                        {
                            Id = 1,
                            GroupId = 1,
                            RegisteredInCity = true,
                            Attendances = new List<Attendance>()
                            {
                                new Attendance()
                                {
                                    ChildId = 1,
                                    Date = new DateTime(2017, 10, 1),
                                    Id = 1,
                                    NoReasons = 0,
                                    Sick = 20,
                                    OtherReasons = 0,
                                }
                            },
                        }
                    }
                },
                new Group()
                {
                    Id = 2,
                    Name = "SMALSU�IAI (ALERG.)",
                    KindergardenId = 1,
                    Children  = new List<Child>()
                    {
                        new Child()
                        {
                            Id = 2,
                            GroupId = 2,
                            RegisteredInCity = false,
                            Attendances = new List<Attendance>()
                            {
                                new Attendance()
                                {
                                    ChildId = 2,
                                    Date = new DateTime(2017, 10, 1),
                                    Id = 2,
                                    NoReasons = 0,
                                    Sick = 0,
                                    OtherReasons = 2,
                                }
                            },
                        }
                    }
                }

            }
        };

        [TestMethod]
        public void GetKindergardensOK()
        {
            var kg = new List<Kindergarden>()
            {
                Kindergarden, Kindergarden, Kindergarden, Kindergarden
            };
            
            var repo = new Repository(kg);
            var km = new KindergardenManager(repo);
            var kindergardens = km.GetKindergardens();

            Assert.AreEqual(4, kindergardens.Count);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data {

    public static partial class ResourceAppointmentCollection {
        public static List<Appointment> GetAppointments() {
            DateTime date = DateTime.Now.Date;
            var dataSource = new List<Appointment>() {
                new Appointment {
                    Accepted = true,
                    Caption = "Install New Router in Dev Room",
                    StartDate = date + (new TimeSpan(0, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 12, 0, 0)),
                    Status = 1,
                    ResourceId = 0
                },
                new Appointment {
                    Caption = "Upgrade Personal Computers",
                    Accepted = false,
                    StartDate = date + (new TimeSpan(0,  13, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 14, 30, 0)),
                    Status = 2,
                    ResourceId = 0
                },
                new Appointment {
                    Caption = "Website Redesign Plan",
                    Accepted = false,
                    StartDate = date + (new TimeSpan(1, 9, 30, 0)),
                    EndDate = date + (new TimeSpan(1, 11, 30, 0)),
                    Status = 3,
                    ResourceId = 0
                },
                new Appointment {
                    Caption = "New Brochures",
                    Accepted = true,
                    StartDate = date + (new TimeSpan(1, 13, 30, 0)),
                    EndDate = date + (new TimeSpan(1, 15, 15, 0)),
                    Status = 4,
                    ResourceId = 0
                },
                new Appointment {
                    Caption = "Book Flights to San Fran for Sales Trip",
                    Accepted = false,
                    StartDate = date + (new TimeSpan(1, 12, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 13, 0, 0)),
                    AllDay = true,
                    Status = 1,
                    ResourceId = 0
                },
                new Appointment {
                    Caption = "Approve Personal Computer Upgrade Plan",
                    Accepted = true,
                    StartDate = date + (new TimeSpan(0, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 12, 0, 0)),
                    Status = 2
                },
                new Appointment {
                    Caption = "Final Budget Review",
                    Accepted = true,
                    StartDate = date + (new TimeSpan(0, 13, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 15, 0, 0)),
                    Status = 3,
                    ResourceId = 1
                },
                new Appointment {
                    Caption = "Install New Database",
                    Accepted = false,
                    StartDate = date + (new TimeSpan(0, 9, 45, 0)),
                    EndDate = date + (new TimeSpan(1, 11, 15, 0)),
                    Status = 4,
                    ResourceId = 1
                },
                new Appointment {
                    Accepted = true,
                    Caption = "Approve New Online Marketing Strategy",
                    StartDate = date + (new TimeSpan(1,  12, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 14, 0, 0)),
                    Status = 1,
                    ResourceId = 1
                },
                new Appointment {
                    Accepted = true,
                    Caption = "Customer Workshop",
                    StartDate = date + (new TimeSpan(0,  11, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 12, 0, 0)),
                    AllDay = true,
                    Status = 2,
                    ResourceId = 2
                },
                new Appointment {
                    Accepted = true,
                    Caption = "Prepare 2021 Marketing Plan",
                    StartDate = date + (new TimeSpan(0,  11, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 13, 30, 0)),
                    Status = 3,
                    ResourceId = 2
                },
                new Appointment {
                    Accepted = false,
                    Caption = "Brochure Design Review",
                    StartDate = date + (new TimeSpan(0, 14, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 15, 30, 0)),
                    Status = 4,
                    ResourceId = 2
                },
                new Appointment {
                    Accepted = true,
                    Caption = "Create Icons for Website",
                    StartDate = date + (new TimeSpan(1, 10, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 11, 30, 0)),
                    Status = 1,
                    ResourceId = 1
                },
                new Appointment {
                    Accepted = true,
                    Caption = "Launch New Website",
                    StartDate = date + (new TimeSpan(1, 12, 20, 0)),
                    EndDate = date + (new TimeSpan(1, 14, 0, 0)),
                    Status = 1,
                    ResourceId = 2
                },
                new Appointment {
                    Accepted = false,
                    Caption = "Upgrade Server Hardware",
                    StartDate = date + (new TimeSpan(1, 9, 0, 0)),
                    EndDate = date + (new TimeSpan(1, 12, 0, 0)),
                    Status = 2,
                    ResourceId = 2
                },
                new Appointment {
                    Accepted = true,
                    Caption = "Book Flights to San Fran for Sales Trip",
                    StartDate = date + (new TimeSpan(0, 14, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 17, 0, 0)),
                    Status = 1,
                    ResourceId = 3
                },
                new Appointment {
                    Accepted = true,
                    Caption = "Approve New Online Marketing Strategy",
                    StartDate = date + (new TimeSpan(0,  12, 0, 0)),
                    EndDate = date + (new TimeSpan(0, 15, 0, 0)),
                    Status = 3,
                    ResourceId = 4
                }
            };
            return dataSource;
        }
    }
}

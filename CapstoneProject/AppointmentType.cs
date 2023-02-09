using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969Assessment
{
    internal class AppointmentType
    {
        public int Count { get; set; }
        public string Type { get; set; }

        public static List<AppointmentType> apptsByType = getApptTypes();

        public AppointmentType(int count, string type)
        {
        }

        public static List<AppointmentType> getApptTypes()
        {
            List<AppointmentType> returnList = new List<AppointmentType>();

            int numPresentation = 0;
            int numScrum = 0;
            int numCodeRev = 0;
            int numSprintPlan = 0;
            int numSprintRev = 0;
            int numBacklog = 0;
            int numRetrospective = 0;
            int numReleasePlan = 0;
            int numOneOnOne = 0;
            int numTeamBuilding = 0;
            int numQuarterlyRev = 0;
            int numAllHands = 0;
            int numOther = 0;
            int numTest = 0;

            for (int i = 0; i < Appointment.apptList.Count - 1; i++)
            {
                switch (Appointment.apptList[i].type)
                {
                    case "Presentation":
                        numPresentation++;
                        break;

                    case "Scrum":
                        numScrum++;
                        break;

                    case "Code Review":
                        numCodeRev++;
                        break;

                    case "Sprint Planning":
                        numSprintPlan++;
                        break;

                    case "Sprint Review":
                        numSprintRev++;
                        break;

                    case "Backlog Refinement":
                        numBacklog++;
                        break;

                    case "Retrospective":
                        numRetrospective++;
                        break;

                    case "Release Planning":
                        numReleasePlan++;
                        break;

                    case "One-on-one":
                        numOneOnOne++;
                        break;

                    case "Team Building":
                        numTeamBuilding++;
                        break;

                    case "Quarterly review":
                        numQuarterlyRev++;
                        break;

                    case "All-hands":
                        numAllHands++;
                        break;

                    case "Other":
                        numOther++;
                        break;

                    case "test":
                        numTest++;
                        break;

                    default:
                        numOther++;
                        break;
                }
            }

            returnList.Add(new AppointmentType(numPresentation, "Presentation"));
            returnList.Add(new AppointmentType(numScrum, "Scrum"));
            returnList.Add(new AppointmentType(numCodeRev, "Code Review"));
            returnList.Add(new AppointmentType(numSprintPlan, "Sprint Planning"));
            returnList.Add(new AppointmentType(numSprintRev, "Sprint Review"));
            returnList.Add(new AppointmentType(numBacklog, "Backlog Refinement"));
            returnList.Add(new AppointmentType(numRetrospective, "Retrospective"));
            returnList.Add(new AppointmentType(numReleasePlan, "Release Planning"));
            returnList.Add(new AppointmentType(numOneOnOne, "One-on-one"));
            returnList.Add(new AppointmentType(numTeamBuilding, "Team Building"));
            returnList.Add(new AppointmentType(numQuarterlyRev, "Quarterly Review"));
            returnList.Add(new AppointmentType(numAllHands, "All-hands"));
            returnList.Add(new AppointmentType(numOther, "Other"));
            returnList.Add(new AppointmentType(numTest, "test"));

            return returnList;

            /*apptsByType.Add(new AppointmentType(numPresentation, "Presentation"));
            apptsByType.Add(new AppointmentType(numScrum, "Scrum"));
            apptsByType.Add(new AppointmentType(numCodeRev, "Code Review"));
            apptsByType.Add(new AppointmentType(numSprintPlan, "Sprint Planning"));
            apptsByType.Add(new AppointmentType(numSprintRev, "Sprint Review"));
            apptsByType.Add(new AppointmentType(numBacklog, "Backlog Refinement"));
            apptsByType.Add(new AppointmentType(numRetrospective, "Retrospective"));
            apptsByType.Add(new AppointmentType(numReleasePlan, "Release Planning"));
            apptsByType.Add(new AppointmentType(numOneOnOne, "One-on-one"));
            apptsByType.Add(new AppointmentType(numTeamBuilding, "Team Building"));
            apptsByType.Add(new AppointmentType(numQuarterlyRev, "Quarterly Review"));
            apptsByType.Add(new AppointmentType(numAllHands, "All-hands"));
            apptsByType.Add(new AppointmentType(numOther, "Other"));
            apptsByType.Add(new AppointmentType(numTest, "test"));*/
        }
    }
}
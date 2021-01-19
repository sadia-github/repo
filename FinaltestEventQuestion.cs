using System;
using System.Collections;

namespace FinalEventQuestion
{

public class Program
    {
        public static void Main()
        {
             Doctor doctor = new Doctor();
            Patient patient = new Patient ();
            Ambulance ambulance = new Ambulance();
                      
            Emergency myemergency = new Emergency();
      
            myemergency.CallForEmergency += doctor.EmergencyCall;
            myemergency.CallForEmergency += patient.EmergencyCall;
            myemergency.CallForEmergency += ambulance.EmergencyCall;
         
            myemergency.createNotification("Milton Hospital");

        }
    }

    public class Doctor
    {
        public void EmergencyCall(object sender, EmergencyInfo e)
        {
            Console.WriteLine("Doctor Call " + e.hospital);
        }

    }
    public class Patient
    {
        public void EmergencyCall(object sender, EmergencyInfo e)
        {
            Console.WriteLine("Patient Call " + e.hospital);
        }

    }
    public class Ambulance
    {
  
        public void EmergencyCall(object sender, EmergencyInfo e)
        {
            Console.WriteLine("Ambulance call " + e.hospital);
        }

    }

    public class Emergency
    {
           public event EmergencyEvent CallForEmergency;
             
        public void createNotification(string msg)
        {
  
            if (CallForEmergency!= null)
            {
                CallForEmergency(this, new EmergencyInfo(msg));
            }
        }
    }

    
    public delegate void EmergencyEvent(object sender, EmergencyInfo e);
        
    public class EmergencyInfo : EventArgs
    {
        public string hospital{ get; set; }
        public EmergencyInfo(string Hospital)
        {
            hospital = Hospital;
        }
    }

}

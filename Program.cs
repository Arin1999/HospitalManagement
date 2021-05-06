/*Question 2:
create class patient
	name, age, address, disease and doctor in charge, room no
1.Add a new Patient Record when admitted.
	check patient details is avilable or not
		if avilable show error msg
		if not avilable enter the other details and store the details
2.Edit/Update Patient Details.
	check patient details is avilable or not
		if not avilable show error msg
		if avilable show the privious details and ask for change or not
			if yes chenge the value by asking the new value
3.List all the Patient Records.
	check the length of the objec
		if  0 show the msg no details present
		else show the all patient details
4.Delete Patient Record when discharged.
	check patient details is avilable or not
		if not avilable show error msg
		if avilable delete the recod

*/
using System;

namespace HospitalManagement
{
	class HospitalManagement
	{
		public static int CheckDetailsPresentOrNot(Patients[] patients, String name)
		{
			for (int i = 0; i < patients.Length; i++)
			{
				if (name.Equals(patients[i].Name))
				{
					return i;
				}
			}
			return -1;

		}
		public static Patients[] AddPatientsDetails(Patients[] patients, String name, int age, String address, String disease, String doctorName, int roomNo)
		{
			int size = patients.Length + 1;
			Patients[] temp = patients;
			patients = new Patients[size];
			for (int i = 0; i < size - 1; i++)
			{
				patients[i] = temp[i];
			}
			patients[size - 1] = new Patients(name, age, address, disease, doctorName, roomNo);
			return patients;
		}
		public static void DisplayAllPatients(Patients[] patients)
		{
			Console.WriteLine("     Name      age      address      disease      doctorName      roomNo      ");
			Console.WriteLine("==============================================================================");
			for (int i = 0; i < patients.Length; i++)
			{
				Console.WriteLine(patients[i].Name + "	" + patients[i].Age + "	" + patients[i].Address + "	" + patients[i].Disease + "	" + patients[i].DoctorName + "		" + patients[i].RoomNo);

			}
		}
		public static Patients[] DeletePatientsDetails(Patients[] patients, int nameIndex)
		{
			int size = patients.Length - 1;
			Patients[] temp = patients;
			patients = new Patients[size];
			for (int i = 0, j = 0; i < size;)
			{
				if (i != nameIndex)
				{
					patients[i++] = temp[j++];

				}
				else
				{
					j++;
				}
			}
			return patients;
		}
		static void Main(string[] args)
		{
			Patients[] patients = new Patients[0];
			bool flag = true;
			do
			{
				Console.WriteLine("Enter 1.Add a new Patient Record when admitted.");
				Console.WriteLine("Enter 2.Edit/Update Patient Details");
				Console.WriteLine("Enter 3.List all the Patient Records.");
				Console.WriteLine("Enter 4.Delete Patient Record when discharged.");
				Console.WriteLine("Enter 5.Exit");
				Console.WriteLine("Enter 5.Exit");
				int key = Convert.ToInt32(Console.ReadLine());
				switch (key)
				{
					case 1:
						{
							Console.WriteLine("Enter the Patients name");
							String name = Console.ReadLine();
							int nameIndex = CheckDetailsPresentOrNot(patients, name);
							if (nameIndex == -1)
							{
								Console.WriteLine("Enter age");
								int age = Convert.ToInt32(Console.ReadLine());
								Console.WriteLine("Enter Address");
								String address = Console.ReadLine();
								Console.WriteLine("Enter disease Name");
								String disease = Console.ReadLine();
								Console.WriteLine("Enter Doctor Name");
								String doctorName = Console.ReadLine();
								Console.WriteLine("Enter Room No");
								int roomNo = Convert.ToInt32(Console.ReadLine());
								patients = AddPatientsDetails(patients, name, age, address, disease, doctorName, roomNo);
							}
							else
							{
								Console.WriteLine("patients details already pesent");
							}
							break;
						}
					case 2:
						{
							Console.WriteLine("Enter the Patients name");
							String name = Console.ReadLine();
							int nameIndex = CheckDetailsPresentOrNot(patients, name);
							if (nameIndex == -1)
							{
								Console.WriteLine("Patients Details not Found");
							}
							else
							{
								Console.WriteLine(patients[nameIndex].Name + " age is " + patients[nameIndex].Age + "Do you want to Edit Y/N");
								char change = Console.ReadLine()[0];
								if (change == 'Y')
								{
									Console.WriteLine("Enter new age");
									patients[nameIndex].Age = Convert.ToInt32(Console.ReadLine());

								}
								Console.WriteLine(patients[nameIndex].Name + " address is " + patients[nameIndex].Address + "Do you want to Edit Y/N");
								change = Console.ReadLine()[0];
								if (change == 'Y')
								{
									Console.WriteLine("Enter new address");
									patients[nameIndex].Address = Console.ReadLine();

								}
								Console.WriteLine(patients[nameIndex].Name + " disease is " + patients[nameIndex].Disease + "Do you want to Edit Y/N");
								change = Console.ReadLine()[0];
								if (change == 'Y')
								{
									Console.WriteLine("Enter new disease");
									patients[nameIndex].Disease = Console.ReadLine();

								}
								Console.WriteLine(patients[nameIndex].Name + " DoctorName is " + patients[nameIndex].DoctorName + "Do you want to Edit Y/N");
								change = Console.ReadLine()[0];
								if (change == 'Y')
								{
									Console.WriteLine("Enter new DoctorName");
									patients[nameIndex].DoctorName = Console.ReadLine();

								}
								Console.WriteLine(patients[nameIndex].Name + " roomNo is " + patients[nameIndex].RoomNo + "Do you want to Edit Y/N");
								change = Console.ReadLine()[0];
								if (change == 'Y')
								{
									Console.WriteLine("Enter new RoomNo ");
									patients[nameIndex].RoomNo = Convert.ToInt32(Console.ReadLine());

								}

							}
							break;
						}
					case 3:
						{
							if (patients.Length == 0)
							{
								Console.WriteLine("No Recorde is there");
							}
							else
							{
								DisplayAllPatients(patients);
							}
							break;
						}
					case 4:
						{
							Console.WriteLine("Enter the Patients name");
							String name = Console.ReadLine();
							int nameIndex = CheckDetailsPresentOrNot(patients, name);
							if (nameIndex == -1)
							{
								Console.WriteLine("Patients Details not Found");
							}
							else
							{
								patients = DeletePatientsDetails(patients, nameIndex);
							}
							break;
						}
					case 5:
						{
							flag = false;
							break;
						}
					default:
						{
							Console.WriteLine("Please enter right choice");
							break;
						}
				}
			}
			while (flag);
		}
	}
}

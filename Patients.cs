using System;

namespace HospitalManagement
{
	public class Patients
	{
		private String _name;
		private int _age;
		private String _address;
		private String _disease;
		private String _doctorName;
		private int _roomNo;
		public Patients() { }
		public Patients(String name, int age, String address, String disease, String doctorName, int roomNo)
		{
			this._name = name;
			this._age = age;
			this._address = address;
			this._disease = disease;
			this._doctorName = doctorName;
			this._roomNo = roomNo;
		}
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}
		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				_age = value;
			}
		}
		public string Address
		{
			get
			{
				return _address;
			}
			set
			{
				_address = value;
			}
		}

		public string Disease
		{
			get
			{
				return _disease;
			}
			set
			{
				_disease = value;
			}
		}
		public string DoctorName
		{
			get
			{
				return _doctorName;
			}
			set
			{
				_doctorName = value;
			}
		}
		public int RoomNo
		{
			get
			{
				return _roomNo;
			}
			set
			{
				_roomNo = value;
			}
		}
	}
}

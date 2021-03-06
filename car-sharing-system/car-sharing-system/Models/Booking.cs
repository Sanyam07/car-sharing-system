﻿using System;
using System.Diagnostics;

namespace car_sharing_system.Models
{
	public class Booking {
		public int bookingID { get; }
		public int accountID { get; }
		public String numberPlate { get; }
		public long bookingDate { get; set; }
		public long startDate { get; set; }
		public long estEndDate { get; set; }
		public long? endDate { get; set; }
		public Location latlong { get; set; }
		public Double travelDistance { get; set; }
		public Double? totalCost { get; set;}

		// Used to add new booking
		public Booking(int accountID, String numberPlate, long bookingDate, long startDate, long estEndDate, Location latlong) {
			this.accountID = accountID;
			this.numberPlate = numberPlate;
			this.bookingDate = bookingDate;
			this.startDate = startDate;
			this.estEndDate = estEndDate;
			this.latlong = latlong;
		}

		// Used to add new booking from web api
		public Booking(int accountID, String numberPlate, long bookingDate, long startDate, long estEndDate) {
			this.accountID = accountID;
			this.numberPlate = numberPlate;
			this.bookingDate = bookingDate;
			this.startDate = startDate;
			this.estEndDate = estEndDate;
		}

		// Used to get full new booking
		public Booking(int bookingID, int accountID, String numberPlate, long bookingDate, long startDate,
					long estEndDate, long endDate, Location latlong, Double travelDistance, Double totalCost)
        {
            this.bookingID = bookingID;
            this.accountID = accountID;
            this.numberPlate = numberPlate;
			this.bookingDate = bookingDate;
            this.startDate = startDate;
			this.estEndDate = estEndDate;
            this.endDate = endDate;
            this.latlong = latlong;
			this.travelDistance = travelDistance;
			this.totalCost = totalCost;
        }

		// Used to get unfinish booking
        public Booking(int bookingID, int accountID, String numberPlate, long bookingDate, long startDate,
					long estEndDate, Location latlong) {
            this.bookingID = bookingID;
            this.accountID = accountID;
            this.numberPlate = numberPlate;
			this.bookingDate = bookingDate;
			this.startDate = startDate;
			this.estEndDate = estEndDate;
			this.latlong = latlong;
        }

		public bool isFinish() {
			if (totalCost == null) {
				return false;
			} else {
				return true;
			}
		}

		public TimeSpan overdueTime() {
			if (isOverdue()) {
				DateTime endDateTime = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToDouble(endDate));
				DateTime estEndDateTime = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToDouble(estEndDate));
				return endDateTime.Subtract(estEndDateTime);
			} else {
				return new TimeSpan(0); ;
			}
		}

		public bool isOverdue() {
			if (estEndDate < endDate)
				return true;
			else
				return false;
		}

		public Double calCost(long endDate) {
			Double cost;
			Car car = DatabaseReader.carQuerySingle("numberPlate = '" + numberPlate + "'");
			if (estEndDate < endDate) {
				cost = ((Double)(endDate - startDate) / 3600) * car.rate;
			} else {
				cost = ((Double)(estEndDate - startDate) / 3600) * car.rate;
			}
			return cost;
		}

		public void debug() {
			Debug.WriteLine("id " + accountID + " book a car for " + startDate + " until " + estEndDate);
			latlong.debug();
			String start = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToDouble(startDate)).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
			String estend = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToDouble(estEndDate)).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
			if (endDate == null) {
				Debug.WriteLine("start at (" + start + ") until (" + estend + ")");
			} else {
				String end = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(Convert.ToDouble(endDate)).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
				Debug.WriteLine("start at (" + start + ") until (" + estend + ") and returned at (" + end + ")");
			}
		}
    }
}
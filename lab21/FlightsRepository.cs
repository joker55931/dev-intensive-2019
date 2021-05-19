using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lab21 {
				public class FlightsRepository {
								private static char csvSeparator = '*';
								private static string sourceFilePath = @"./flights.csv";

								public static List<Flight> GetAllFlights() {
												try {
																List<Flight> flights = new List<Flight>();

																string[] fileData = File.ReadAllLines(sourceFilePath);
																foreach(string line in fileData) {
																				string[] values = line.Split(csvSeparator);
																				flights.Add(new Flight() {
																								Code = flights.Count.ToString(),
																								TransportType = values[0],
																								Start = values[1],
																								Destination = values[2],
																								Price = (float)Convert.ToDouble(values[3]),
																				});
																}
																return flights;
												}
												catch(Exception) {
																return new List<Flight>();
												}
								}

								public static void SaveAllFlights(List<Flight> flights) {
												List<string> data = flights.ConvertAll(f => $"{f.TransportType}{csvSeparator}{f.Start}{csvSeparator}{f.Destination}{csvSeparator}{f.Price}");
												File.Delete(sourceFilePath);
												File.WriteAllLines(sourceFilePath, data);
								}
				}
}

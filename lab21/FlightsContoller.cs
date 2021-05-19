using System;
using System.Collections.Generic;
using System.Linq;

namespace lab21 {
				public class FlightsContoller {
								private List<FlightProvider> flights = new List<FlightProvider>();

								public FlightsContoller() {
												List<Flight> _flights = FlightsRepository.GetAllFlights();
												flights = _flights.ConvertAll(f => new FlightProvider(f));
								}

								public List<FlightProvider> AllFlights {
												get => flights;
								}

								public int ByBusAmount {
												get => flights.FindAll(f => f.TransportType == "Автобус").Count;
								}

								public float ByPlannesPrices {
												get => flights
																.FindAll(f => f.TransportType == "Самолет")
																.Aggregate(0f, (acc, f) => acc + f.Price);
								}

								public float MaxFlightPrice {
												get => flights.OrderByDescending(f => f.Price).First().Price;
								}
				}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab21 {
				public class FlightProvider {
								private Flight flight;

								public FlightProvider(Flight f) {
												flight = f;
								}

								public string Code {
												get => flight.Code;
												set {
																flight.Code = value;
												}
								}

								public string TransportType {
												get => flight.TransportType;
												set {
																flight.TransportType = value;
												}
								}

								public string Start {
												get => flight.Start;
												set {
																flight.Start = value;
												}
								}

								public string Destinnation {
												get => flight.Destination;
												set {
																flight.Destination = value;
												}
								}

								public float Price {
												get => flight.Price;
												set {
																flight.Price = value;
												}
								}

								public string FlightInfo {
												get => $"{flight.Start} -> {flight.Destination}. {flight.Price}, {flight.TransportType}";
								}
				}
}

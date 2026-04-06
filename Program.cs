
Centralita centralita = new Centralita();

Console.WriteLine("REGISTRO DE LLAMADAS\n");

//locales
LlamadaLocal local1 = new LlamadaLocal("8496382070", "8095555555", 5.0, 0);
LlamadaLocal local2 = new LlamadaLocal("8095555555", "8496382070", 10.0, 0);
LlamadaLocal local3 = new LlamadaLocal("8496382070", "8095555555", 3.5, 0);

//procinciales
LlamadaProvincial prov1 = new LlamadaProvincial("8496382070", "8095555555", 4.0, 1);
LlamadaProvincial prov2 = new LlamadaProvincial("8095555555", "8496382070", 7.0, 2);
LlamadaProvincial prov3 = new LlamadaProvincial("8496382070", "8095555555", 6.0, 3);


centralita.registrarLlamada(local1);
centralita.registrarLlamada(local2);
centralita.registrarLlamada(local3);
centralita.registrarLlamada(prov1);
centralita.registrarLlamada(prov2);
centralita.registrarLlamada(prov3);


Console.WriteLine("\nResumen Final");
Console.WriteLine($"Total de llamadas : {centralita.getTotalLlamadas()}");
Console.WriteLine($"Total facturado   : {centralita.getTotalFacturado():F2}€"); 

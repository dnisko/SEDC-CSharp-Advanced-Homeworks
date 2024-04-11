namespace Task01.Models
{
    public static class CarsData
    {
        public static List<Car> Cars = new List<Car>();

        static CarsData()
        {
            LoadCars();
        }

        public static void LoadCars()
        {
            Cars = new List<Car>()
            {
                new Car()
                {
                    Model = "Chevrolet Chevelle Malibu", MilesPerGallon = 18, AccelerationTime = 12, Cylinders = 8,
                    HorsePower = 130, Origin = "US", Weight = 3504
                },
                new Car()
                {
                    Model = "Buick Skylark 320", MilesPerGallon = 15, AccelerationTime = 11.5, Cylinders = 8,
                    HorsePower = 165, Origin = "US", Weight = 3693
                },
                new Car()
                {
                    Model = "Plymouth Satellite", MilesPerGallon = 18, AccelerationTime = 11, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 3436
                },
                new Car()
                {
                    Model = "AMC Rebel SST", MilesPerGallon = 16, AccelerationTime = 12, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 3433
                },
                new Car()
                {
                    Model = "Ford Torino", MilesPerGallon = 17, AccelerationTime = 10.5, Cylinders = 8,
                    HorsePower = 140, Origin = "US", Weight = 3449
                },
                new Car()
                {
                    Model = "Ford Galaxie 500", MilesPerGallon = 15, AccelerationTime = 10, Cylinders = 8,
                    HorsePower = 198, Origin = "US", Weight = 4341
                },
                new Car()
                {
                    Model = "Chevrolet Impala", MilesPerGallon = 14, AccelerationTime = 9, Cylinders = 8,
                    HorsePower = 220, Origin = "US", Weight = 4354
                },
                new Car()
                {
                    Model = "Plymouth Fury iii", MilesPerGallon = 14, AccelerationTime = 8.5, Cylinders = 8,
                    HorsePower = 215, Origin = "US", Weight = 4312
                },
                new Car()
                {
                    Model = "Pontiac Catalina", MilesPerGallon = 14, AccelerationTime = 10, Cylinders = 8,
                    HorsePower = 225, Origin = "US", Weight = 4425
                },
                new Car()
                {
                    Model = "AMC Ambassador DPL", MilesPerGallon = 15, AccelerationTime = 8.5, Cylinders = 8,
                    HorsePower = 190, Origin = "US", Weight = 3850
                },
                new Car()
                {
                    Model = "Citroen DS-21 Pallas", MilesPerGallon = 0, AccelerationTime = 17.5, Cylinders = 4,
                    HorsePower = 115, Origin = "Europe", Weight = 3090
                },
                new Car()
                {
                    Model = "Chevrolet Chevelle Concours (sw)", MilesPerGallon = 0, AccelerationTime = 11.5,
                    Cylinders = 8, HorsePower = 165, Origin = "US", Weight = 4142
                },
                new Car()
                {
                    Model = "Ford Torino (sw)", MilesPerGallon = 0, AccelerationTime = 11, Cylinders = 8,
                    HorsePower = 153, Origin = "US", Weight = 4034
                },
                new Car()
                {
                    Model = "Plymouth Satellite (sw)", MilesPerGallon = 0, AccelerationTime = 10.5, Cylinders = 8,
                    HorsePower = 175, Origin = "US", Weight = 4166
                },
                new Car()
                {
                    Model = "AMC Rebel SST (sw)", MilesPerGallon = 0, AccelerationTime = 11, Cylinders = 8,
                    HorsePower = 175, Origin = "US", Weight = 3850
                },
                new Car()
                {
                    Model = "Dodge Challenger SE", MilesPerGallon = 15, AccelerationTime = 10, Cylinders = 8,
                    HorsePower = 170, Origin = "US", Weight = 3563
                },
                new Car()
                {
                    Model = "Plymouth 'Cuda 340", MilesPerGallon = 14, AccelerationTime = 8, Cylinders = 8,
                    HorsePower = 160, Origin = "US", Weight = 3609
                },
                new Car()
                {
                    Model = "Ford Mustang Boss 302", MilesPerGallon = 0, AccelerationTime = 8, Cylinders = 8,
                    HorsePower = 140, Origin = "US", Weight = 3353
                },
                new Car()
                {
                    Model = "Chevrolet Monte Carlo", MilesPerGallon = 15, AccelerationTime = 9.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 3761
                },
                new Car()
                {
                    Model = "Buick Estate Wagon (sw)", MilesPerGallon = 14, AccelerationTime = 10, Cylinders = 8,
                    HorsePower = 225, Origin = "US", Weight = 3086
                },
                new Car()
                {
                    Model = "Toyota Corolla Mark ii", MilesPerGallon = 24, AccelerationTime = 15, Cylinders = 4,
                    HorsePower = 95, Origin = "Japan", Weight = 2372
                },
                new Car()
                {
                    Model = "Plymouth Duster", MilesPerGallon = 22, AccelerationTime = 15.5, Cylinders = 6,
                    HorsePower = 95, Origin = "US", Weight = 2833
                },
                new Car()
                {
                    Model = "AMC Hornet", MilesPerGallon = 18, AccelerationTime = 15.5, Cylinders = 6, HorsePower = 97,
                    Origin = "US", Weight = 2774
                },
                new Car()
                {
                    Model = "Ford Maverick", MilesPerGallon = 21, AccelerationTime = 16, Cylinders = 6, HorsePower = 85,
                    Origin = "US", Weight = 2587
                },
                new Car()
                {
                    Model = "Datsun PL510", MilesPerGallon = 27, AccelerationTime = 14.5, Cylinders = 4,
                    HorsePower = 88, Origin = "Japan", Weight = 2130
                },
                new Car()
                {
                    Model = "Volkswagen 1131 Deluxe Sedan", MilesPerGallon = 26, AccelerationTime = 20.5, Cylinders = 4,
                    HorsePower = 46, Origin = "Europe", Weight = 1835
                },
                new Car()
                {
                    Model = "Peugeot 504", MilesPerGallon = 25, AccelerationTime = 17.5, Cylinders = 4, HorsePower = 87,
                    Origin = "Europe", Weight = 2672
                },
                new Car()
                {
                    Model = "Audi 100 LS", MilesPerGallon = 24, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 90,
                    Origin = "Europe", Weight = 2430
                },
                new Car()
                {
                    Model = "Saab 99e", MilesPerGallon = 25, AccelerationTime = 17.5, Cylinders = 4, HorsePower = 95,
                    Origin = "Europe", Weight = 2375
                },
                new Car()
                {
                    Model = "BMW 2002", MilesPerGallon = 26, AccelerationTime = 12.5, Cylinders = 4, HorsePower = 113,
                    Origin = "Europe", Weight = 2234
                },
                new Car()
                {
                    Model = "AMC Gremlin", MilesPerGallon = 21, AccelerationTime = 15, Cylinders = 6, HorsePower = 90,
                    Origin = "US", Weight = 2648
                },
                new Car()
                {
                    Model = "Ford F250", MilesPerGallon = 10, AccelerationTime = 14, Cylinders = 8, HorsePower = 215,
                    Origin = "US", Weight = 4615
                },
                new Car()
                {
                    Model = "Chevy C20", MilesPerGallon = 10, AccelerationTime = 15, Cylinders = 8, HorsePower = 200,
                    Origin = "US", Weight = 4376
                },
                new Car()
                {
                    Model = "Dodge D200", MilesPerGallon = 11, AccelerationTime = 13.5, Cylinders = 8, HorsePower = 210,
                    Origin = "US", Weight = 4382
                },
                new Car()
                {
                    Model = "Hi 1200D", MilesPerGallon = 9, AccelerationTime = 18.5, Cylinders = 8, HorsePower = 193,
                    Origin = "US", Weight = 4732
                },
                new Car()
                {
                    Model = "Datsun PL510", MilesPerGallon = 27, AccelerationTime = 14.5, Cylinders = 4,
                    HorsePower = 88, Origin = "Japan", Weight = 2130
                },
                new Car()
                {
                    Model = "Chevrolet Vega 2300", MilesPerGallon = 28, AccelerationTime = 15.5, Cylinders = 4,
                    HorsePower = 90, Origin = "US", Weight = 2264
                },
                new Car()
                {
                    Model = "Toyota Corolla", MilesPerGallon = 25, AccelerationTime = 14, Cylinders = 4,
                    HorsePower = 95, Origin = "Japan", Weight = 2228
                },
                new Car()
                {
                    Model = "Ford Pinto", MilesPerGallon = 25, AccelerationTime = 19, Cylinders = 4, HorsePower = 0,
                    Origin = "US", Weight = 2046
                },
                new Car()
                {
                    Model = "Volkswagen Super Beetle 117", MilesPerGallon = 0, AccelerationTime = 20, Cylinders = 4,
                    HorsePower = 48, Origin = "Europe", Weight = 1978
                },
                new Car()
                {
                    Model = "AMC Gremlin", MilesPerGallon = 19, AccelerationTime = 13, Cylinders = 6, HorsePower = 100,
                    Origin = "US", Weight = 2634
                },
                new Car()
                {
                    Model = "Plymouth Satellite Custom", MilesPerGallon = 16, AccelerationTime = 15.5, Cylinders = 6,
                    HorsePower = 105, Origin = "US", Weight = 3439
                },
                new Car()
                {
                    Model = "Chevrolet Chevelle Malibu", MilesPerGallon = 17, AccelerationTime = 15.5, Cylinders = 6,
                    HorsePower = 100, Origin = "US", Weight = 3329
                },
                new Car()
                {
                    Model = "Ford Torino 500", MilesPerGallon = 19, AccelerationTime = 15.5, Cylinders = 6,
                    HorsePower = 88, Origin = "US", Weight = 3302
                },
                new Car()
                {
                    Model = "AMC Matador", MilesPerGallon = 18, AccelerationTime = 15.5, Cylinders = 6,
                    HorsePower = 100, Origin = "US", Weight = 3288
                },
                new Car()
                {
                    Model = "Chevrolet Impala", MilesPerGallon = 14, AccelerationTime = 12, Cylinders = 8,
                    HorsePower = 165, Origin = "US", Weight = 4209
                },
                new Car()
                {
                    Model = "Pontiac Catalina Brougham", MilesPerGallon = 14, AccelerationTime = 11.5, Cylinders = 8,
                    HorsePower = 175, Origin = "US", Weight = 4464
                },
                new Car()
                {
                    Model = "Ford Galaxie 500", MilesPerGallon = 14, AccelerationTime = 13.5, Cylinders = 8,
                    HorsePower = 153, Origin = "US", Weight = 4154
                },
                new Car()
                {
                    Model = "Plymouth Fury iii", MilesPerGallon = 14, AccelerationTime = 13, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4096
                },
                new Car()
                {
                    Model = "Dodge Monaco (sw)", MilesPerGallon = 12, AccelerationTime = 11.5, Cylinders = 8,
                    HorsePower = 180, Origin = "US", Weight = 4955
                },
                new Car()
                {
                    Model = "Ford Country Squire (sw)", MilesPerGallon = 13, AccelerationTime = 12, Cylinders = 8,
                    HorsePower = 170, Origin = "US", Weight = 4746
                },
                new Car()
                {
                    Model = "Pontiac Safari (sw)", MilesPerGallon = 13, AccelerationTime = 12, Cylinders = 8,
                    HorsePower = 175, Origin = "US", Weight = 5140
                },
                new Car()
                {
                    Model = "AMC Hornet Sportabout (sw)", MilesPerGallon = 18, AccelerationTime = 13.5, Cylinders = 6,
                    HorsePower = 110, Origin = "US", Weight = 2962
                },
                new Car()
                {
                    Model = "Chevrolet Vega (sw)", MilesPerGallon = 22, AccelerationTime = 19, Cylinders = 4,
                    HorsePower = 72, Origin = "US", Weight = 2408
                },
                new Car()
                {
                    Model = "Pontiac Firebird", MilesPerGallon = 19, AccelerationTime = 15, Cylinders = 6,
                    HorsePower = 100, Origin = "US", Weight = 3282
                },
                new Car()
                {
                    Model = "Ford Mustang", MilesPerGallon = 18, AccelerationTime = 14.5, Cylinders = 6,
                    HorsePower = 88, Origin = "US", Weight = 3139
                },
                new Car()
                {
                    Model = "Mercury Capri 2000", MilesPerGallon = 23, AccelerationTime = 14, Cylinders = 4,
                    HorsePower = 86, Origin = "US", Weight = 2220
                },
                new Car()
                {
                    Model = "Opel 1900", MilesPerGallon = 28, AccelerationTime = 14, Cylinders = 4, HorsePower = 90,
                    Origin = "Europe", Weight = 2123
                },
                new Car()
                {
                    Model = "Peugeot 304", MilesPerGallon = 30, AccelerationTime = 19.5, Cylinders = 4, HorsePower = 70,
                    Origin = "Europe", Weight = 2074
                },
                new Car()
                {
                    Model = "Fiat 124B", MilesPerGallon = 30, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 76,
                    Origin = "Europe", Weight = 2065
                },
                new Car()
                {
                    Model = "Toyota Corolla 1200", MilesPerGallon = 31, AccelerationTime = 19, Cylinders = 4,
                    HorsePower = 65, Origin = "Japan", Weight = 1773
                },
                new Car()
                {
                    Model = "Datsun 1200", MilesPerGallon = 35, AccelerationTime = 18, Cylinders = 4, HorsePower = 69,
                    Origin = "Japan", Weight = 1613
                },
                new Car()
                {
                    Model = "Volkswagen Model 111", MilesPerGallon = 27, AccelerationTime = 19, Cylinders = 4,
                    HorsePower = 60, Origin = "Europe", Weight = 1834
                },
                new Car()
                {
                    Model = "Plymouth Cricket", MilesPerGallon = 26, AccelerationTime = 20.5, Cylinders = 4,
                    HorsePower = 70, Origin = "US", Weight = 1955
                },
                new Car()
                {
                    Model = "Toyota Corolla Hardtop", MilesPerGallon = 24, AccelerationTime = 15.5, Cylinders = 4,
                    HorsePower = 95, Origin = "Japan", Weight = 2278
                },
                new Car()
                {
                    Model = "Dodge Colt Hardtop", MilesPerGallon = 25, AccelerationTime = 17, Cylinders = 4,
                    HorsePower = 80, Origin = "US", Weight = 2126
                },
                new Car()
                {
                    Model = "Volkswagen Type 3", MilesPerGallon = 23, AccelerationTime = 23.5, Cylinders = 4,
                    HorsePower = 54, Origin = "Europe", Weight = 2254
                },
                new Car()
                {
                    Model = "Chevrolet Vega", MilesPerGallon = 20, AccelerationTime = 19.5, Cylinders = 4,
                    HorsePower = 90, Origin = "US", Weight = 2408
                },
                new Car()
                {
                    Model = "Ford Pinto Runabout", MilesPerGallon = 21, AccelerationTime = 16.5, Cylinders = 4,
                    HorsePower = 86, Origin = "US", Weight = 2226
                },
                new Car()
                {
                    Model = "Chevrolet Impala", MilesPerGallon = 13, AccelerationTime = 12, Cylinders = 8,
                    HorsePower = 165, Origin = "US", Weight = 4274
                },
                new Car()
                {
                    Model = "Pontiac Catalina", MilesPerGallon = 14, AccelerationTime = 12, Cylinders = 8,
                    HorsePower = 175, Origin = "US", Weight = 4385
                },
                new Car()
                {
                    Model = "Plymouth Fury III", MilesPerGallon = 15, AccelerationTime = 13.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4135
                },
                new Car()
                {
                    Model = "Ford Galaxie 500", MilesPerGallon = 14, AccelerationTime = 13, Cylinders = 8,
                    HorsePower = 153, Origin = "US", Weight = 4129
                },
                new Car()
                {
                    Model = "AMC Ambassador SST", MilesPerGallon = 17, AccelerationTime = 11.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 3672
                },
                new Car()
                {
                    Model = "Mercury Marquis", MilesPerGallon = 11, AccelerationTime = 11, Cylinders = 8,
                    HorsePower = 208, Origin = "US", Weight = 4633
                },
                new Car()
                {
                    Model = "Buick LeSabre Custom", MilesPerGallon = 13, AccelerationTime = 13.5, Cylinders = 8,
                    HorsePower = 155, Origin = "US", Weight = 4502
                },
                new Car()
                {
                    Model = "Oldsmobile Delta 88 Royale", MilesPerGallon = 12, AccelerationTime = 13.5, Cylinders = 8,
                    HorsePower = 160, Origin = "US", Weight = 4456
                },
                new Car()
                {
                    Model = "Chrysler Newport Royal", MilesPerGallon = 13, AccelerationTime = 12.5, Cylinders = 8,
                    HorsePower = 190, Origin = "US", Weight = 4422
                },
                new Car()
                {
                    Model = "Mazda RX2 Coupe", MilesPerGallon = 19, AccelerationTime = 13.5, Cylinders = 3,
                    HorsePower = 97, Origin = "Japan", Weight = 2330
                },
                new Car()
                {
                    Model = "AMC Matador (sw)", MilesPerGallon = 15, AccelerationTime = 12.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 3892
                },
                new Car()
                {
                    Model = "Chevrolet Chevelle Concours (sw)", MilesPerGallon = 13, AccelerationTime = 14,
                    Cylinders = 8, HorsePower = 130, Origin = "US", Weight = 4098
                },
                new Car()
                {
                    Model = "Ford Gran Torino (sw)", MilesPerGallon = 13, AccelerationTime = 16, Cylinders = 8,
                    HorsePower = 140, Origin = "US", Weight = 4294
                },
                new Car()
                {
                    Model = "Plymouth Satellite Custom (sw)", MilesPerGallon = 14, AccelerationTime = 14, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4077
                },
                new Car()
                {
                    Model = "Volvo 145e (sw)", MilesPerGallon = 18, AccelerationTime = 14.5, Cylinders = 4,
                    HorsePower = 112, Origin = "Europe", Weight = 2933
                },
                new Car()
                {
                    Model = "Volkswagen 411 (sw)", MilesPerGallon = 22, AccelerationTime = 18, Cylinders = 4,
                    HorsePower = 76, Origin = "Europe", Weight = 2511
                },
                new Car()
                {
                    Model = "Peugeot 504 (sw)", MilesPerGallon = 21, AccelerationTime = 19.5, Cylinders = 4,
                    HorsePower = 87, Origin = "Europe", Weight = 2979
                },
                new Car()
                {
                    Model = "Renault 12 (sw)", MilesPerGallon = 26, AccelerationTime = 18, Cylinders = 4,
                    HorsePower = 69, Origin = "Europe", Weight = 2189
                },
                new Car()
                {
                    Model = "Ford Pinto (sw)", MilesPerGallon = 22, AccelerationTime = 16, Cylinders = 4,
                    HorsePower = 86, Origin = "US", Weight = 2395
                },
                new Car()
                {
                    Model = "Datsun 510 (sw)", MilesPerGallon = 28, AccelerationTime = 17, Cylinders = 4,
                    HorsePower = 92, Origin = "Japan", Weight = 2288
                },
                new Car()
                {
                    Model = "Toyota Corolla Mark II (sw)", MilesPerGallon = 23, AccelerationTime = 14.5, Cylinders = 4,
                    HorsePower = 97, Origin = "Japan", Weight = 2506
                },
                new Car()
                {
                    Model = "Dodge Colt (sw)", MilesPerGallon = 28, AccelerationTime = 15, Cylinders = 4,
                    HorsePower = 80, Origin = "US", Weight = 2164
                },
                new Car()
                {
                    Model = "Toyota Corolla 1600 (sw)", MilesPerGallon = 27, AccelerationTime = 16.5, Cylinders = 4,
                    HorsePower = 88, Origin = "Japan", Weight = 2100
                },
                new Car()
                {
                    Model = "Buick Century 350", MilesPerGallon = 13, AccelerationTime = 13, Cylinders = 8,
                    HorsePower = 175, Origin = "US", Weight = 4100
                },
                new Car()
                {
                    Model = "AMC Matador", MilesPerGallon = 14, AccelerationTime = 11.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 3672
                },
                new Car()
                {
                    Model = "Chevrolet Malibu", MilesPerGallon = 13, AccelerationTime = 13, Cylinders = 8,
                    HorsePower = 145, Origin = "US", Weight = 3988
                },
                new Car()
                {
                    Model = "Ford Gran Torino", MilesPerGallon = 14, AccelerationTime = 14.5, Cylinders = 8,
                    HorsePower = 137, Origin = "US", Weight = 4042
                },
                new Car()
                {
                    Model = "Dodge Coronet Custom", MilesPerGallon = 15, AccelerationTime = 12.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 3777
                },
                new Car()
                {
                    Model = "Mercury Marquis Brougham", MilesPerGallon = 12, AccelerationTime = 11.5, Cylinders = 8,
                    HorsePower = 198, Origin = "US", Weight = 4952
                },
                new Car()
                {
                    Model = "Chevrolet Caprice Classic", MilesPerGallon = 13, AccelerationTime = 12, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4464
                },
                new Car()
                {
                    Model = "Ford LTD", MilesPerGallon = 13, AccelerationTime = 13, Cylinders = 8, HorsePower = 158,
                    Origin = "US", Weight = 4363
                },
                new Car()
                {
                    Model = "Plymouth Fury Gran Sedan", MilesPerGallon = 14, AccelerationTime = 14.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4237
                },
                new Car()
                {
                    Model = "Chrysler New Yorker Brougham", MilesPerGallon = 13, AccelerationTime = 11, Cylinders = 8,
                    HorsePower = 215, Origin = "US", Weight = 4735
                },
                new Car()
                {
                    Model = "Buick Electra 225 Custom", MilesPerGallon = 12, AccelerationTime = 11, Cylinders = 8,
                    HorsePower = 225, Origin = "US", Weight = 4951
                },
                new Car()
                {
                    Model = "AMC Ambassador Brougham", MilesPerGallon = 13, AccelerationTime = 11, Cylinders = 8,
                    HorsePower = 175, Origin = "US", Weight = 3821
                },
                new Car()
                {
                    Model = "Plymouth Valiant", MilesPerGallon = 18, AccelerationTime = 16.5, Cylinders = 6,
                    HorsePower = 105, Origin = "US", Weight = 3121
                },
                new Car()
                {
                    Model = "Chevrolet Nova Custom", MilesPerGallon = 16, AccelerationTime = 18, Cylinders = 6,
                    HorsePower = 100, Origin = "US", Weight = 3278
                },
                new Car()
                {
                    Model = "AMC Hornet", MilesPerGallon = 18, AccelerationTime = 16, Cylinders = 6, HorsePower = 100,
                    Origin = "US", Weight = 2945
                },
                new Car()
                {
                    Model = "Ford Maverick", MilesPerGallon = 18, AccelerationTime = 16.5, Cylinders = 6,
                    HorsePower = 88, Origin = "US", Weight = 3021
                },
                new Car()
                {
                    Model = "Plymouth Duster", MilesPerGallon = 23, AccelerationTime = 16, Cylinders = 6,
                    HorsePower = 95, Origin = "US", Weight = 2904
                },
                new Car()
                {
                    Model = "Volkswagen Super Beetle", MilesPerGallon = 26, AccelerationTime = 21, Cylinders = 4,
                    HorsePower = 46, Origin = "Europe", Weight = 1950
                },
                new Car()
                {
                    Model = "Chevrolet Impala", MilesPerGallon = 11, AccelerationTime = 14, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4997
                },
                new Car()
                {
                    Model = "Ford Country", MilesPerGallon = 12, AccelerationTime = 12.5, Cylinders = 8,
                    HorsePower = 167, Origin = "US", Weight = 4906
                },
                new Car()
                {
                    Model = "Plymouth Custom Suburb", MilesPerGallon = 13, AccelerationTime = 13, Cylinders = 8,
                    HorsePower = 170, Origin = "US", Weight = 4654
                },
                new Car()
                {
                    Model = "Oldsmobile Vista Cruiser", MilesPerGallon = 12, AccelerationTime = 12.5, Cylinders = 8,
                    HorsePower = 180, Origin = "US", Weight = 4499
                },
                new Car()
                {
                    Model = "AMC Gremlin", MilesPerGallon = 18, AccelerationTime = 15, Cylinders = 6, HorsePower = 100,
                    Origin = "US", Weight = 2789
                },
                new Car()
                {
                    Model = "Toyota Camry", MilesPerGallon = 20, AccelerationTime = 19, Cylinders = 4, HorsePower = 88,
                    Origin = "Japan", Weight = 2279
                },
                new Car()
                {
                    Model = "Chevrolet Vega", MilesPerGallon = 21, AccelerationTime = 19.5, Cylinders = 4,
                    HorsePower = 72, Origin = "US", Weight = 2401
                },
                new Car()
                {
                    Model = "Datsun 610", MilesPerGallon = 22, AccelerationTime = 16.5, Cylinders = 4, HorsePower = 94,
                    Origin = "Japan", Weight = 2379
                },
                new Car()
                {
                    Model = "Mazda RX3", MilesPerGallon = 18, AccelerationTime = 13.5, Cylinders = 3, HorsePower = 90,
                    Origin = "Japan", Weight = 2124
                },
                new Car()
                {
                    Model = "Ford Pinto", MilesPerGallon = 19, AccelerationTime = 18.5, Cylinders = 4, HorsePower = 85,
                    Origin = "US", Weight = 2310
                },
                new Car()
                {
                    Model = "Mercury Capri v6", MilesPerGallon = 21, AccelerationTime = 14, Cylinders = 6,
                    HorsePower = 107, Origin = "US", Weight = 2472
                },
                new Car()
                {
                    Model = "Fiat 124 Sport Coupe", MilesPerGallon = 26, AccelerationTime = 15.5, Cylinders = 4,
                    HorsePower = 90, Origin = "Europe", Weight = 2265
                },
                new Car()
                {
                    Model = "Chevrolet Monte Carlo S", MilesPerGallon = 15, AccelerationTime = 13, Cylinders = 8,
                    HorsePower = 145, Origin = "US", Weight = 4082
                },
                new Car()
                {
                    Model = "Pontiac Grand Prix", MilesPerGallon = 16, AccelerationTime = 9.5, Cylinders = 8,
                    HorsePower = 230, Origin = "US", Weight = 4278
                },
                new Car()
                {
                    Model = "Fiat 128", MilesPerGallon = 29, AccelerationTime = 19.5, Cylinders = 4, HorsePower = 49,
                    Origin = "Europe", Weight = 1867
                },
                new Car()
                {
                    Model = "Opel Manta", MilesPerGallon = 24, AccelerationTime = 15.5, Cylinders = 4, HorsePower = 75,
                    Origin = "Europe", Weight = 2158
                },
                new Car()
                {
                    Model = "Audi 100LS", MilesPerGallon = 20, AccelerationTime = 14, Cylinders = 4, HorsePower = 91,
                    Origin = "Europe", Weight = 2582
                },
                new Car()
                {
                    Model = "Volvo 144ea", MilesPerGallon = 19, AccelerationTime = 15.5, Cylinders = 4,
                    HorsePower = 112, Origin = "Europe", Weight = 2868
                },
                new Car()
                {
                    Model = "Dodge Dart Custom", MilesPerGallon = 15, AccelerationTime = 11, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 3399
                },
                new Car()
                {
                    Model = "Saab 99le", MilesPerGallon = 24, AccelerationTime = 14, Cylinders = 4, HorsePower = 110,
                    Origin = "Europe", Weight = 2660
                },
                new Car()
                {
                    Model = "Toyota Mark II", MilesPerGallon = 20, AccelerationTime = 13.5, Cylinders = 6,
                    HorsePower = 122, Origin = "Japan", Weight = 2807
                },
                new Car()
                {
                    Model = "Oldsmobile Omega", MilesPerGallon = 11, AccelerationTime = 11, Cylinders = 8,
                    HorsePower = 180, Origin = "US", Weight = 3664
                },
                new Car()
                {
                    Model = "Plymouth Duster", MilesPerGallon = 20, AccelerationTime = 16.5, Cylinders = 6,
                    HorsePower = 95, Origin = "US", Weight = 3102
                },
                new Car()
                {
                    Model = "Ford Maverick", MilesPerGallon = 21, AccelerationTime = 17, Cylinders = 6, HorsePower = 0,
                    Origin = "US", Weight = 2875
                },
                new Car()
                {
                    Model = "AMC Hornet", MilesPerGallon = 19, AccelerationTime = 16, Cylinders = 6, HorsePower = 100,
                    Origin = "US", Weight = 2901
                },
                new Car()
                {
                    Model = "Chevrolet Nova", MilesPerGallon = 15, AccelerationTime = 17, Cylinders = 6,
                    HorsePower = 100, Origin = "US", Weight = 3336
                },
                new Car()
                {
                    Model = "Datsun B210", MilesPerGallon = 31, AccelerationTime = 19, Cylinders = 4, HorsePower = 67,
                    Origin = "Japan", Weight = 1950
                },
                new Car()
                {
                    Model = "Ford Pinto", MilesPerGallon = 26, AccelerationTime = 16.5, Cylinders = 4, HorsePower = 80,
                    Origin = "US", Weight = 2451
                },
                new Car()
                {
                    Model = "Toyota Corolla 1200", MilesPerGallon = 32, AccelerationTime = 21, Cylinders = 4,
                    HorsePower = 65, Origin = "Japan", Weight = 1836
                },
                new Car()
                {
                    Model = "Chevrolet Vega", MilesPerGallon = 25, AccelerationTime = 17, Cylinders = 4,
                    HorsePower = 75, Origin = "US", Weight = 2542
                },
                new Car()
                {
                    Model = "Chevrolet Chevelle Malibu Classic", MilesPerGallon = 16, AccelerationTime = 17,
                    Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 3781
                },
                new Car()
                {
                    Model = "AMC Matador", MilesPerGallon = 16, AccelerationTime = 18, Cylinders = 6, HorsePower = 110,
                    Origin = "US", Weight = 3632
                },
                new Car()
                {
                    Model = "Plymouth Satellite Sebring", MilesPerGallon = 18, AccelerationTime = 16.5, Cylinders = 6,
                    HorsePower = 105, Origin = "US", Weight = 3613
                },
                new Car()
                {
                    Model = "Ford Gran Torino", MilesPerGallon = 16, AccelerationTime = 14, Cylinders = 8,
                    HorsePower = 140, Origin = "US", Weight = 4141
                },
                new Car()
                {
                    Model = "Buick Century Luxus (sw)", MilesPerGallon = 13, AccelerationTime = 14.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4699
                },
                new Car()
                {
                    Model = "Dodge Coronet Custom (sw)", MilesPerGallon = 14, AccelerationTime = 13.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4457
                },
                new Car()
                {
                    Model = "Ford Gran Torino (sw)", MilesPerGallon = 14, AccelerationTime = 16, Cylinders = 8,
                    HorsePower = 140, Origin = "US", Weight = 4638
                },
                new Car()
                {
                    Model = "AMC Matador (sw)", MilesPerGallon = 14, AccelerationTime = 15.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4257
                },
                new Car()
                {
                    Model = "Audi Fox", MilesPerGallon = 29, AccelerationTime = 16.5, Cylinders = 4, HorsePower = 83,
                    Origin = "Europe", Weight = 2219
                },
                new Car()
                {
                    Model = "Volkswagen Dasher", MilesPerGallon = 26, AccelerationTime = 15.5, Cylinders = 4,
                    HorsePower = 67, Origin = "Europe", Weight = 1963
                },
                new Car()
                {
                    Model = "Opel Manta", MilesPerGallon = 26, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 78,
                    Origin = "Europe", Weight = 2300
                },
                new Car()
                {
                    Model = "Toyota Corolla", MilesPerGallon = 31, AccelerationTime = 16.5, Cylinders = 4,
                    HorsePower = 52, Origin = "Japan", Weight = 1649
                },
                new Car()
                {
                    Model = "Datsun 710", MilesPerGallon = 32, AccelerationTime = 19, Cylinders = 4, HorsePower = 61,
                    Origin = "Japan", Weight = 2003
                },
                new Car()
                {
                    Model = "Dodge Colt", MilesPerGallon = 28, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 75,
                    Origin = "US", Weight = 2125
                },
                new Car()
                {
                    Model = "Fiat 128", MilesPerGallon = 24, AccelerationTime = 15.5, Cylinders = 4, HorsePower = 75,
                    Origin = "Europe", Weight = 2108
                },
                new Car()
                {
                    Model = "Fiat 124 TC", MilesPerGallon = 26, AccelerationTime = 14, Cylinders = 4, HorsePower = 75,
                    Origin = "Europe", Weight = 2246
                },
                new Car()
                {
                    Model = "Honda Civic", MilesPerGallon = 24, AccelerationTime = 15, Cylinders = 4, HorsePower = 97,
                    Origin = "Japan", Weight = 2489
                },
                new Car()
                {
                    Model = "Subaru", MilesPerGallon = 26, AccelerationTime = 15.5, Cylinders = 4, HorsePower = 93,
                    Origin = "Japan", Weight = 2391
                },
                new Car()
                {
                    Model = "Fiat x1.9", MilesPerGallon = 31, AccelerationTime = 16, Cylinders = 4, HorsePower = 67,
                    Origin = "Europe", Weight = 2000
                },
                new Car()
                {
                    Model = "Plymouth Valiant Custom", MilesPerGallon = 19, AccelerationTime = 16, Cylinders = 6,
                    HorsePower = 95, Origin = "US", Weight = 3264
                },
                new Car()
                {
                    Model = "Chevrolet Nova", MilesPerGallon = 18, AccelerationTime = 16, Cylinders = 6,
                    HorsePower = 105, Origin = "US", Weight = 3459
                },
                new Car()
                {
                    Model = "Mercury Monarch", MilesPerGallon = 15, AccelerationTime = 21, Cylinders = 6,
                    HorsePower = 72, Origin = "US", Weight = 3432
                },
                new Car()
                {
                    Model = "Ford Maverick", MilesPerGallon = 15, AccelerationTime = 19.5, Cylinders = 6,
                    HorsePower = 72, Origin = "US", Weight = 3158
                },
                new Car()
                {
                    Model = "Pontiac Catalina", MilesPerGallon = 16, AccelerationTime = 11.5, Cylinders = 8,
                    HorsePower = 170, Origin = "US", Weight = 4668
                },
                new Car()
                {
                    Model = "Chevrolet Bel Air", MilesPerGallon = 15, AccelerationTime = 14, Cylinders = 8,
                    HorsePower = 145, Origin = "US", Weight = 4440
                },
                new Car()
                {
                    Model = "Plymouth Grand Fury", MilesPerGallon = 16, AccelerationTime = 14.5, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4498
                },
                new Car()
                {
                    Model = "Ford LTD", MilesPerGallon = 14, AccelerationTime = 13.5, Cylinders = 8, HorsePower = 148,
                    Origin = "US", Weight = 4657
                },
                new Car()
                {
                    Model = "Buick Century", MilesPerGallon = 17, AccelerationTime = 21, Cylinders = 6,
                    HorsePower = 110, Origin = "US", Weight = 3907
                },
                new Car()
                {
                    Model = "Chevrolete Chevelle Malibu", MilesPerGallon = 16, AccelerationTime = 18.5, Cylinders = 6,
                    HorsePower = 105, Origin = "US", Weight = 3897
                },
                new Car()
                {
                    Model = "AMC Matador", MilesPerGallon = 15, AccelerationTime = 19, Cylinders = 6, HorsePower = 110,
                    Origin = "US", Weight = 3730
                },
                new Car()
                {
                    Model = "Plymouth Fury", MilesPerGallon = 18, AccelerationTime = 19, Cylinders = 6, HorsePower = 95,
                    Origin = "US", Weight = 3785
                },
                new Car()
                {
                    Model = "Buick Skyhawk", MilesPerGallon = 21, AccelerationTime = 15, Cylinders = 6,
                    HorsePower = 110, Origin = "US", Weight = 3039
                },
                new Car()
                {
                    Model = "Chevrolet Monza 2+2", MilesPerGallon = 20, AccelerationTime = 13.5, Cylinders = 8,
                    HorsePower = 110, Origin = "US", Weight = 3221
                },
                new Car()
                {
                    Model = "Ford Mustang II", MilesPerGallon = 13, AccelerationTime = 12, Cylinders = 8,
                    HorsePower = 129, Origin = "US", Weight = 3169
                },
                new Car()
                {
                    Model = "Toyota Corolla", MilesPerGallon = 29, AccelerationTime = 16, Cylinders = 4,
                    HorsePower = 75, Origin = "Japan", Weight = 2171
                },
                new Car()
                {
                    Model = "Ford Pinto", MilesPerGallon = 23, AccelerationTime = 17, Cylinders = 4, HorsePower = 83,
                    Origin = "US", Weight = 2639
                },
                new Car()
                {
                    Model = "AMC Gremlin", MilesPerGallon = 20, AccelerationTime = 16, Cylinders = 6, HorsePower = 100,
                    Origin = "US", Weight = 2914
                },
                new Car()
                {
                    Model = "Pontiac Astro", MilesPerGallon = 23, AccelerationTime = 18.5, Cylinders = 4,
                    HorsePower = 78, Origin = "US", Weight = 2592
                },
                new Car()
                {
                    Model = "Toyota Corolla", MilesPerGallon = 24, AccelerationTime = 13.5, Cylinders = 4,
                    HorsePower = 96, Origin = "Japan", Weight = 2702
                },
                new Car()
                {
                    Model = "Volkswagen Dasher", MilesPerGallon = 25, AccelerationTime = 16.5, Cylinders = 4,
                    HorsePower = 71, Origin = "Europe", Weight = 2223
                },
                new Car()
                {
                    Model = "Datsun 710", MilesPerGallon = 24, AccelerationTime = 17, Cylinders = 4, HorsePower = 97,
                    Origin = "Japan", Weight = 2545
                },
                new Car()
                {
                    Model = "Ford Pinto", MilesPerGallon = 18, AccelerationTime = 14.5, Cylinders = 6, HorsePower = 97,
                    Origin = "US", Weight = 2984
                },
                new Car()
                {
                    Model = "Volkswagen Rabbit", MilesPerGallon = 29, AccelerationTime = 14, Cylinders = 4,
                    HorsePower = 70, Origin = "Europe", Weight = 1937
                },
                new Car()
                {
                    Model = "AMC Pacer", MilesPerGallon = 19, AccelerationTime = 17, Cylinders = 6, HorsePower = 90,
                    Origin = "US", Weight = 3211
                },
                new Car()
                {
                    Model = "Audi 100LS", MilesPerGallon = 23, AccelerationTime = 15, Cylinders = 4, HorsePower = 95,
                    Origin = "Europe", Weight = 2694
                },
                new Car()
                {
                    Model = "Peugeot 504", MilesPerGallon = 23, AccelerationTime = 17, Cylinders = 4, HorsePower = 88,
                    Origin = "Europe", Weight = 2957
                },
                new Car()
                {
                    Model = "Volvo 244DL", MilesPerGallon = 22, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 98,
                    Origin = "Europe", Weight = 2945
                },
                new Car()
                {
                    Model = "Saab 99LE", MilesPerGallon = 25, AccelerationTime = 13.5, Cylinders = 4, HorsePower = 115,
                    Origin = "Europe", Weight = 2671
                },
                new Car()
                {
                    Model = "Honda Civic CVCC", MilesPerGallon = 33, AccelerationTime = 17.5, Cylinders = 4,
                    HorsePower = 53, Origin = "Japan", Weight = 1795
                },
                new Car()
                {
                    Model = "Fiat 131", MilesPerGallon = 28, AccelerationTime = 15.5, Cylinders = 4, HorsePower = 86,
                    Origin = "Europe", Weight = 2464
                },
                new Car()
                {
                    Model = "Opel 1900", MilesPerGallon = 25, AccelerationTime = 16.9, Cylinders = 4, HorsePower = 81,
                    Origin = "Europe", Weight = 2220
                },
                new Car()
                {
                    Model = "Capri ii", MilesPerGallon = 25, AccelerationTime = 14.9, Cylinders = 4, HorsePower = 92,
                    Origin = "US", Weight = 2572
                },
                new Car()
                {
                    Model = "Dodge Colt", MilesPerGallon = 26, AccelerationTime = 17.7, Cylinders = 4, HorsePower = 79,
                    Origin = "US", Weight = 2255
                },
                new Car()
                {
                    Model = "Renault 12tl", MilesPerGallon = 27, AccelerationTime = 15.3, Cylinders = 4,
                    HorsePower = 83, Origin = "Europe", Weight = 2202
                },
                new Car()
                {
                    Model = "Chevrolet Chevelle Malibu Classic", MilesPerGallon = 17.5, AccelerationTime = 13,
                    Cylinders = 8, HorsePower = 140, Origin = "US", Weight = 4215
                },
                new Car()
                {
                    Model = "Dodge Coronet Brougham", MilesPerGallon = 16, AccelerationTime = 13, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 4190
                },
                new Car()
                {
                    Model = "AMC Matador", MilesPerGallon = 15.5, AccelerationTime = 13.9, Cylinders = 8,
                    HorsePower = 120, Origin = "US", Weight = 3962
                },
                new Car()
                {
                    Model = "Ford Gran Torino", MilesPerGallon = 14.5, AccelerationTime = 12.8, Cylinders = 8,
                    HorsePower = 152, Origin = "US", Weight = 4215
                },
                new Car()
                {
                    Model = "Plymouth Valiant", MilesPerGallon = 22, AccelerationTime = 15.4, Cylinders = 6,
                    HorsePower = 100, Origin = "US", Weight = 3233
                },
                new Car()
                {
                    Model = "Chevrolet Nova", MilesPerGallon = 22, AccelerationTime = 14.5, Cylinders = 6,
                    HorsePower = 105, Origin = "US", Weight = 3353
                },
                new Car()
                {
                    Model = "Ford Maverick", MilesPerGallon = 24, AccelerationTime = 17.6, Cylinders = 6,
                    HorsePower = 81, Origin = "US", Weight = 3012
                },
                new Car()
                {
                    Model = "AMC Hornet", MilesPerGallon = 22.5, AccelerationTime = 17.6, Cylinders = 6,
                    HorsePower = 90, Origin = "US", Weight = 3085
                },
                new Car()
                {
                    Model = "Chevrolet Chevette", MilesPerGallon = 29, AccelerationTime = 22.2, Cylinders = 4,
                    HorsePower = 52, Origin = "US", Weight = 2035
                },
                new Car()
                {
                    Model = "Chevrolet Woody", MilesPerGallon = 24.5, AccelerationTime = 22.1, Cylinders = 4,
                    HorsePower = 60, Origin = "US", Weight = 2164
                },
                new Car()
                {
                    Model = "Volkswagen Rabbit", MilesPerGallon = 29, AccelerationTime = 14.2, Cylinders = 4,
                    HorsePower = 70, Origin = "Europe", Weight = 1937
                },
                new Car()
                {
                    Model = "Honda Civic", MilesPerGallon = 33, AccelerationTime = 17.4, Cylinders = 4, HorsePower = 53,
                    Origin = "Japan", Weight = 1795
                },
                new Car()
                {
                    Model = "Dodge Aspen SE", MilesPerGallon = 20, AccelerationTime = 17.7, Cylinders = 6,
                    HorsePower = 100, Origin = "US", Weight = 3651
                },
                new Car()
                {
                    Model = "Ford Grenada ghia", MilesPerGallon = 18, AccelerationTime = 21, Cylinders = 6,
                    HorsePower = 78, Origin = "US", Weight = 3574
                },
                new Car()
                {
                    Model = "Pontiac Ventura SJ", MilesPerGallon = 18.5, AccelerationTime = 16.2, Cylinders = 6,
                    HorsePower = 110, Origin = "US", Weight = 3645
                },
                new Car()
                {
                    Model = "AMC Pacer d/l", MilesPerGallon = 17.5, AccelerationTime = 17.8, Cylinders = 6,
                    HorsePower = 95, Origin = "US", Weight = 3193
                },
                new Car()
                {
                    Model = "Volkswagen Rabbit", MilesPerGallon = 29.5, AccelerationTime = 12.2, Cylinders = 4,
                    HorsePower = 71, Origin = "Europe", Weight = 1825
                },
                new Car()
                {
                    Model = "Datsun B-210", MilesPerGallon = 32, AccelerationTime = 17, Cylinders = 4, HorsePower = 70,
                    Origin = "Japan", Weight = 1990
                },
                new Car()
                {
                    Model = "Toyota Corolla", MilesPerGallon = 28, AccelerationTime = 16.4, Cylinders = 4,
                    HorsePower = 75, Origin = "Japan", Weight = 2155
                },
                new Car()
                {
                    Model = "Ford Pinto", MilesPerGallon = 26.5, AccelerationTime = 13.6, Cylinders = 4,
                    HorsePower = 72, Origin = "US", Weight = 2565
                },
                new Car()
                {
                    Model = "Volvo 245", MilesPerGallon = 20, AccelerationTime = 15.7, Cylinders = 4, HorsePower = 102,
                    Origin = "Europe", Weight = 3150
                },
                new Car()
                {
                    Model = "Plymouth Volare Premier v8", MilesPerGallon = 13, AccelerationTime = 13.2, Cylinders = 8,
                    HorsePower = 150, Origin = "US", Weight = 3940
                },
                new Car()
                {
                    Model = "Peugeot 504", MilesPerGallon = 19, AccelerationTime = 21.9, Cylinders = 4, HorsePower = 88,
                    Origin = "Europe", Weight = 3270
                },
                new Car()
                {
                    Model = "Toyota Mark II", MilesPerGallon = 19, AccelerationTime = 15.5, Cylinders = 6,
                    HorsePower = 108, Origin = "Japan", Weight = 2930
                },
                new Car()
                {
                    Model = "Mercedes-Benz 280s", MilesPerGallon = 16.5, AccelerationTime = 16.7, Cylinders = 6,
                    HorsePower = 120, Origin = "Europe", Weight = 3820
                },
                new Car()
                {
                    Model = "Cadillac Seville", MilesPerGallon = 16.5, AccelerationTime = 12.1, Cylinders = 8,
                    HorsePower = 180, Origin = "US", Weight = 4380
                },
                new Car()
                {
                    Model = "Chevrolet C10", MilesPerGallon = 13, AccelerationTime = 12, Cylinders = 8,
                    HorsePower = 145, Origin = "US", Weight = 4055
                },
                new Car()
                {
                    Model = "Ford F108", MilesPerGallon = 13, AccelerationTime = 15, Cylinders = 8, HorsePower = 130,
                    Origin = "US", Weight = 3870
                },
                new Car()
                {
                    Model = "Dodge D100", MilesPerGallon = 13, AccelerationTime = 14, Cylinders = 8, HorsePower = 150,
                    Origin = "US", Weight = 3755
                },
                new Car()
                {
                    Model = "Honda Accord CVCC", MilesPerGallon = 31.5, AccelerationTime = 18.5, Cylinders = 4,
                    HorsePower = 68, Origin = "Japan", Weight = 2045
                },
                new Car()
                {
                    Model = "Buick Opel Isuzu Deluxe", MilesPerGallon = 30, AccelerationTime = 14.8, Cylinders = 4,
                    HorsePower = 80, Origin = "US", Weight = 2155
                },
                new Car()
                {
                    Model = "Renault 5 GTL", MilesPerGallon = 36, AccelerationTime = 18.6, Cylinders = 4,
                    HorsePower = 58, Origin = "Europe", Weight = 1825
                },
                new Car()
                {
                    Model = "Plymouth Arrow GS", MilesPerGallon = 25.5, AccelerationTime = 15.5, Cylinders = 4,
                    HorsePower = 96, Origin = "US", Weight = 2300
                },
                new Car()
                {
                    Model = "Datsun F-10 Hatchback", MilesPerGallon = 33.5, AccelerationTime = 16.8, Cylinders = 4,
                    HorsePower = 70, Origin = "Japan", Weight = 1945
                },
                new Car()
                {
                    Model = "Chevrolet Caprice Classic", MilesPerGallon = 17.5, AccelerationTime = 12.5, Cylinders = 8,
                    HorsePower = 145, Origin = "US", Weight = 3880
                },
                new Car()
                {
                    Model = "Oldsmobile Cutlass Supreme", MilesPerGallon = 17, AccelerationTime = 19, Cylinders = 8,
                    HorsePower = 110, Origin = "US", Weight = 4060
                },
                new Car()
                {
                    Model = "Dodge Monaco Brougham", MilesPerGallon = 15.5, AccelerationTime = 13.7, Cylinders = 8,
                    HorsePower = 145, Origin = "US", Weight = 4140
                },
                new Car()
                {
                    Model = "Mercury Cougar Brougham", MilesPerGallon = 15, AccelerationTime = 14.9, Cylinders = 8,
                    HorsePower = 130, Origin = "US", Weight = 4295
                },
                new Car()
                {
                    Model = "Chevrolet Concours", MilesPerGallon = 17.5, AccelerationTime = 16.4, Cylinders = 6,
                    HorsePower = 110, Origin = "US", Weight = 3520
                },
                new Car()
                {
                    Model = "Buick Skylark", MilesPerGallon = 20.5, AccelerationTime = 16.9, Cylinders = 6,
                    HorsePower = 105, Origin = "US", Weight = 3425
                },
                new Car()
                {
                    Model = "Plymouth Volare Custom", MilesPerGallon = 19, AccelerationTime = 17.7, Cylinders = 6,
                    HorsePower = 100, Origin = "US", Weight = 3630
                },
                new Car()
                {
                    Model = "Ford Grenada", MilesPerGallon = 18.5, AccelerationTime = 19, Cylinders = 6,
                    HorsePower = 98, Origin = "US", Weight = 3525
                },
                new Car()
                {
                    Model = "Pontiac Grand Prix LJ", MilesPerGallon = 16, AccelerationTime = 11.1, Cylinders = 8,
                    HorsePower = 180, Origin = "US", Weight = 4220
                },
                new Car()
                {
                    Model = "Chevrolet Monte Carlo Landau", MilesPerGallon = 15.5, AccelerationTime = 11.4,
                    Cylinders = 8, HorsePower = 170, Origin = "US", Weight = 4165
                },
                new Car()
                {
                    Model = "Chrysler Cordoba", MilesPerGallon = 15.5, AccelerationTime = 12.2, Cylinders = 8,
                    HorsePower = 190, Origin = "US", Weight = 4325
                },
                new Car()
                {
                    Model = "Ford Thunderbird", MilesPerGallon = 16, AccelerationTime = 14.5, Cylinders = 8,
                    HorsePower = 149, Origin = "US", Weight = 4335
                },
                new Car()
                {
                    Model = "Volkswagen Rabbit Custom", MilesPerGallon = 29, AccelerationTime = 14.5, Cylinders = 4,
                    HorsePower = 78, Origin = "Europe", Weight = 1940
                },
                new Car()
                {
                    Model = "Pontiac Sunbird Coupe", MilesPerGallon = 24.5, AccelerationTime = 16, Cylinders = 4,
                    HorsePower = 88, Origin = "US", Weight = 2740
                },
                new Car()
                {
                    Model = "Toyota Corolla Liftback", MilesPerGallon = 26, AccelerationTime = 18.2, Cylinders = 4,
                    HorsePower = 75, Origin = "Japan", Weight = 2265
                },
                new Car()
                {
                    Model = "Ford Mustang II 2+2", MilesPerGallon = 25.5, AccelerationTime = 15.8, Cylinders = 4,
                    HorsePower = 89, Origin = "US", Weight = 2755
                },
                new Car()
                {
                    Model = "Chevrolet Chevette", MilesPerGallon = 30.5, AccelerationTime = 17, Cylinders = 4,
                    HorsePower = 63, Origin = "US", Weight = 2051
                },
                new Car()
                {
                    Model = "Dodge Colt m/m", MilesPerGallon = 33.5, AccelerationTime = 15.9, Cylinders = 4,
                    HorsePower = 83, Origin = "US", Weight = 2075
                },
                new Car()
                {
                    Model = "Subaru DL", MilesPerGallon = 30, AccelerationTime = 16.4, Cylinders = 4, HorsePower = 67,
                    Origin = "Japan", Weight = 1985
                },
                new Car()
                {
                    Model = "Volkswagen Dasher", MilesPerGallon = 30.5, AccelerationTime = 14.1, Cylinders = 4,
                    HorsePower = 78, Origin = "Europe", Weight = 2190
                },
                new Car()
                {
                    Model = "Datsun 810", MilesPerGallon = 22, AccelerationTime = 14.5, Cylinders = 6, HorsePower = 97,
                    Origin = "Japan", Weight = 2815
                },
                new Car()
                {
                    Model = "BMW 320i", MilesPerGallon = 21.5, AccelerationTime = 12.8, Cylinders = 4, HorsePower = 110,
                    Origin = "Europe", Weight = 2600
                },
                new Car()
                {
                    Model = "Mazda RX-4", MilesPerGallon = 21.5, AccelerationTime = 13.5, Cylinders = 3,
                    HorsePower = 110, Origin = "Japan", Weight = 2720
                },
                new Car()
                {
                    Model = "Volkswagen Rabbit Custom Diesel", MilesPerGallon = 43.1, AccelerationTime = 21.5,
                    Cylinders = 4, HorsePower = 48, Origin = "Europe", Weight = 1985
                },
                new Car()
                {
                    Model = "Ford Fiesta", MilesPerGallon = 36.1, AccelerationTime = 14.4, Cylinders = 4,
                    HorsePower = 66, Origin = "US", Weight = 1800
                },
                new Car()
                {
                    Model = "Mazda GLC Deluxe", MilesPerGallon = 32.8, AccelerationTime = 19.4, Cylinders = 4,
                    HorsePower = 52, Origin = "Japan", Weight = 1985
                },
                new Car()
                {
                    Model = "Datsun B210 GX", MilesPerGallon = 39.4, AccelerationTime = 18.6, Cylinders = 4,
                    HorsePower = 70, Origin = "Japan", Weight = 2070
                },
                new Car()
                {
                    Model = "Honda Civic CVCC", MilesPerGallon = 36.1, AccelerationTime = 16.4, Cylinders = 4,
                    HorsePower = 60, Origin = "Japan", Weight = 1800
                },
                new Car()
                {
                    Model = "Oldsmobile Cutlass Salon Brougham", MilesPerGallon = 19.9, AccelerationTime = 15.5,
                    Cylinders = 8, HorsePower = 110, Origin = "US", Weight = 3365
                },
                new Car()
                {
                    Model = "Dodge Diplomat", MilesPerGallon = 19.4, AccelerationTime = 13.2, Cylinders = 8,
                    HorsePower = 140, Origin = "US", Weight = 3735
                },
                new Car()
                {
                    Model = "Mercury Monarch ghia", MilesPerGallon = 20.2, AccelerationTime = 12.8, Cylinders = 8,
                    HorsePower = 139, Origin = "US", Weight = 3570
                },
                new Car()
                {
                    Model = "Pontiac Phoenix LJ", MilesPerGallon = 19.2, AccelerationTime = 19.2, Cylinders = 6,
                    HorsePower = 105, Origin = "US", Weight = 3535
                },
                new Car()
                {
                    Model = "Chevrolet Malibu", MilesPerGallon = 20.5, AccelerationTime = 18.2, Cylinders = 6,
                    HorsePower = 95, Origin = "US", Weight = 3155
                },
                new Car()
                {
                    Model = "Ford Fairmont (auto)", MilesPerGallon = 20.2, AccelerationTime = 15.8, Cylinders = 6,
                    HorsePower = 85, Origin = "US", Weight = 2965
                },
                new Car()
                {
                    Model = "Ford Fairmont (man)", MilesPerGallon = 25.1, AccelerationTime = 15.4, Cylinders = 4,
                    HorsePower = 88, Origin = "US", Weight = 2720
                },
                new Car()
                {
                    Model = "Plymouth Volare", MilesPerGallon = 20.5, AccelerationTime = 17.2, Cylinders = 6,
                    HorsePower = 100, Origin = "US", Weight = 3430
                },
                new Car()
                {
                    Model = "AMC Concord", MilesPerGallon = 19.4, AccelerationTime = 17.2, Cylinders = 6,
                    HorsePower = 90, Origin = "US", Weight = 3210
                },
                new Car()
                {
                    Model = "Buick Century Special", MilesPerGallon = 20.6, AccelerationTime = 15.8, Cylinders = 6,
                    HorsePower = 105, Origin = "US", Weight = 3380
                },
                new Car()
                {
                    Model = "Mercury Zephyr", MilesPerGallon = 20.8, AccelerationTime = 16.7, Cylinders = 6,
                    HorsePower = 85, Origin = "US", Weight = 3070
                },
                new Car()
                {
                    Model = "Dodge Aspen", MilesPerGallon = 18.6, AccelerationTime = 18.7, Cylinders = 6,
                    HorsePower = 110, Origin = "US", Weight = 3620
                },
                new Car()
                {
                    Model = "AMC Concord d/l", MilesPerGallon = 18.1, AccelerationTime = 15.1, Cylinders = 6,
                    HorsePower = 120, Origin = "US", Weight = 3410
                },
                new Car()
                {
                    Model = "Chevrolet Monte Carlo Landau", MilesPerGallon = 19.2, AccelerationTime = 13.2,
                    Cylinders = 8, HorsePower = 145, Origin = "US", Weight = 3425
                },
                new Car()
                {
                    Model = "Buick Regal Sport Coupe (turbo)", MilesPerGallon = 17.7, AccelerationTime = 13.4,
                    Cylinders = 6, HorsePower = 165, Origin = "US", Weight = 3445
                },
                new Car()
                {
                    Model = "Ford Futura", MilesPerGallon = 18.1, AccelerationTime = 11.2, Cylinders = 8,
                    HorsePower = 139, Origin = "US", Weight = 3205
                },
                new Car()
                {
                    Model = "Dodge Magnum XE", MilesPerGallon = 17.5, AccelerationTime = 13.7, Cylinders = 8,
                    HorsePower = 140, Origin = "US", Weight = 4080
                },
                new Car()
                {
                    Model = "Chevrolet Chevette", MilesPerGallon = 30, AccelerationTime = 16.5, Cylinders = 4,
                    HorsePower = 68, Origin = "US", Weight = 2155
                },
                new Car()
                {
                    Model = "Toyota Corolla", MilesPerGallon = 27.5, AccelerationTime = 14.2, Cylinders = 4,
                    HorsePower = 95, Origin = "Japan", Weight = 2560
                },
                new Car()
                {
                    Model = "Datsun 510", MilesPerGallon = 27.2, AccelerationTime = 14.7, Cylinders = 4,
                    HorsePower = 97, Origin = "Japan", Weight = 2300
                },
                new Car()
                {
                    Model = "Dodge Omni", MilesPerGallon = 30.9, AccelerationTime = 14.5, Cylinders = 4,
                    HorsePower = 75, Origin = "US", Weight = 2230
                },
                new Car()
                {
                    Model = "Toyota Celica GT Liftback", MilesPerGallon = 21.1, AccelerationTime = 14.8, Cylinders = 4,
                    HorsePower = 95, Origin = "Japan", Weight = 2515
                },
                new Car()
                {
                    Model = "Plymouth Sapporo", MilesPerGallon = 23.2, AccelerationTime = 16.7, Cylinders = 4,
                    HorsePower = 105, Origin = "US", Weight = 2745
                },
                new Car()
                {
                    Model = "Oldsmobile Starfire SX", MilesPerGallon = 23.8, AccelerationTime = 17.6, Cylinders = 4,
                    HorsePower = 85, Origin = "US", Weight = 2855
                },
                new Car()
                {
                    Model = "Datsun 200-SX", MilesPerGallon = 23.9, AccelerationTime = 14.9, Cylinders = 4,
                    HorsePower = 97, Origin = "Japan", Weight = 2405
                },
                new Car()
                {
                    Model = "Audi 5000", MilesPerGallon = 20.3, AccelerationTime = 15.9, Cylinders = 5,
                    HorsePower = 103, Origin = "Europe", Weight = 2830
                },
                new Car()
                {
                    Model = "Volvo 264gl", MilesPerGallon = 17, AccelerationTime = 13.6, Cylinders = 6,
                    HorsePower = 125, Origin = "Europe", Weight = 3140
                },
                new Car()
                {
                    Model = "Saab 99gle", MilesPerGallon = 21.6, AccelerationTime = 15.7, Cylinders = 4,
                    HorsePower = 115, Origin = "Europe", Weight = 2795
                },
                new Car()
                {
                    Model = "Peugeot 604sl", MilesPerGallon = 16.2, AccelerationTime = 15.8, Cylinders = 6,
                    HorsePower = 133, Origin = "Europe", Weight = 3410
                },
                new Car()
                {
                    Model = "Volkswagen Scirocco", MilesPerGallon = 31.5, AccelerationTime = 14.9, Cylinders = 4,
                    HorsePower = 71, Origin = "Europe", Weight = 1990
                },
                new Car()
                {
                    Model = "Honda Accord LX", MilesPerGallon = 29.5, AccelerationTime = 16.6, Cylinders = 4,
                    HorsePower = 68, Origin = "Japan", Weight = 2135
                },
                new Car()
                {
                    Model = "Pontiac Lemans V6", MilesPerGallon = 21.5, AccelerationTime = 15.4, Cylinders = 6,
                    HorsePower = 115, Origin = "US", Weight = 3245
                },
                new Car()
                {
                    Model = "Mercury Zephyr 6", MilesPerGallon = 19.8, AccelerationTime = 18.2, Cylinders = 6,
                    HorsePower = 85, Origin = "US", Weight = 2990
                },
                new Car()
                {
                    Model = "Ford Fairmont 4", MilesPerGallon = 22.3, AccelerationTime = 17.3, Cylinders = 4,
                    HorsePower = 88, Origin = "US", Weight = 2890
                },
                new Car()
                {
                    Model = "AMC Concord DL 6", MilesPerGallon = 20.2, AccelerationTime = 18.2, Cylinders = 6,
                    HorsePower = 90, Origin = "US", Weight = 3265
                },
                new Car()
                {
                    Model = "Dodge Aspen 6", MilesPerGallon = 20.6, AccelerationTime = 16.6, Cylinders = 6,
                    HorsePower = 110, Origin = "US", Weight = 3360
                },
                new Car()
                {
                    Model = "Chevrolet Caprice Classic", MilesPerGallon = 17, AccelerationTime = 15.4, Cylinders = 8,
                    HorsePower = 130, Origin = "US", Weight = 3840
                },
                new Car()
                {
                    Model = "Ford LTD Landau", MilesPerGallon = 17.6, AccelerationTime = 13.4, Cylinders = 8,
                    HorsePower = 129, Origin = "US", Weight = 3725
                },
                new Car()
                {
                    Model = "Mercury Grand Marquis", MilesPerGallon = 16.5, AccelerationTime = 13.2, Cylinders = 8,
                    HorsePower = 138, Origin = "US", Weight = 3955
                },
                new Car()
                {
                    Model = "Dodge St, Regis", MilesPerGallon = 18.2, AccelerationTime = 15.2, Cylinders = 8,
                    HorsePower = 135, Origin = "US", Weight = 3830
                },
                new Car()
                {
                    Model = "Buick Estate Wagon (sw)", MilesPerGallon = 16.9, AccelerationTime = 14.9, Cylinders = 8,
                    HorsePower = 155, Origin = "US", Weight = 4360
                },
                new Car()
                {
                    Model = "Ford Country Squire (sw)", MilesPerGallon = 15.5, AccelerationTime = 14.3, Cylinders = 8,
                    HorsePower = 142, Origin = "US", Weight = 4054
                },
                new Car()
                {
                    Model = "Chevrolet Malibu Classic (sw)", MilesPerGallon = 19.2, AccelerationTime = 15,
                    Cylinders = 8, HorsePower = 125, Origin = "US", Weight = 3605
                },
                new Car()
                {
                    Model = "Chrysler Lebaron Town @ Country (sw)", MilesPerGallon = 18.5, AccelerationTime = 13,
                    Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 3940
                },
                new Car()
                {
                    Model = "Volkswagen Rabbit Custom", MilesPerGallon = 31.9, AccelerationTime = 14, Cylinders = 4,
                    HorsePower = 71, Origin = "Europe", Weight = 1925
                },
                new Car()
                {
                    Model = "Mazda GLC Deluxe", MilesPerGallon = 34.1, AccelerationTime = 15.2, Cylinders = 4,
                    HorsePower = 65, Origin = "Japan", Weight = 1975
                },
                new Car()
                {
                    Model = "Dodge Colt Hatchback Custom", MilesPerGallon = 35.7, AccelerationTime = 14.4,
                    Cylinders = 4, HorsePower = 80, Origin = "US", Weight = 1915
                },
                new Car()
                {
                    Model = "AMC Spirit DL", MilesPerGallon = 27.4, AccelerationTime = 15, Cylinders = 4,
                    HorsePower = 80, Origin = "US", Weight = 2670
                },
                new Car()
                {
                    Model = "Mercedes Benz 300d", MilesPerGallon = 25.4, AccelerationTime = 20.1, Cylinders = 5,
                    HorsePower = 77, Origin = "Europe", Weight = 3530
                },
                new Car()
                {
                    Model = "Cadillac Eldorado", MilesPerGallon = 23, AccelerationTime = 17.4, Cylinders = 8,
                    HorsePower = 125, Origin = "US", Weight = 3900
                },
                new Car()
                {
                    Model = "Peugeot 504", MilesPerGallon = 27.2, AccelerationTime = 24.8, Cylinders = 4,
                    HorsePower = 71, Origin = "Europe", Weight = 3190
                },
                new Car()
                {
                    Model = "Oldsmobile Cutlass Salon Brougham", MilesPerGallon = 23.9, AccelerationTime = 22.2,
                    Cylinders = 8, HorsePower = 90, Origin = "US", Weight = 3420
                },
                new Car()
                {
                    Model = "Plymouth Horizon", MilesPerGallon = 34.2, AccelerationTime = 13.2, Cylinders = 4,
                    HorsePower = 70, Origin = "US", Weight = 2200
                },
                new Car()
                {
                    Model = "Plymouth Horizon TC3", MilesPerGallon = 34.5, AccelerationTime = 14.9, Cylinders = 4,
                    HorsePower = 70, Origin = "US", Weight = 2150
                },
                new Car()
                {
                    Model = "Datsun 210", MilesPerGallon = 31.8, AccelerationTime = 19.2, Cylinders = 4,
                    HorsePower = 65, Origin = "Japan", Weight = 2020
                },
                new Car()
                {
                    Model = "Fiat Strada Custom", MilesPerGallon = 37.3, AccelerationTime = 14.7, Cylinders = 4,
                    HorsePower = 69, Origin = "Europe", Weight = 2130
                },
                new Car()
                {
                    Model = "Buick Skylark Limited", MilesPerGallon = 28.4, AccelerationTime = 16, Cylinders = 4,
                    HorsePower = 90, Origin = "US", Weight = 2670
                },
                new Car()
                {
                    Model = "Chevrolet Citation", MilesPerGallon = 28.8, AccelerationTime = 11.3, Cylinders = 6,
                    HorsePower = 115, Origin = "US", Weight = 2595
                },
                new Car()
                {
                    Model = "Oldsmobile Omega Brougham", MilesPerGallon = 26.8, AccelerationTime = 12.9, Cylinders = 6,
                    HorsePower = 115, Origin = "US", Weight = 2700
                },
                new Car()
                {
                    Model = "Pontiac Phoenix", MilesPerGallon = 33.5, AccelerationTime = 13.2, Cylinders = 4,
                    HorsePower = 90, Origin = "US", Weight = 2556
                },
                new Car()
                {
                    Model = "Volkswagen Rabbit", MilesPerGallon = 41.5, AccelerationTime = 14.7, Cylinders = 4,
                    HorsePower = 76, Origin = "Europe", Weight = 2144
                },
                new Car()
                {
                    Model = "Toyota Corolla Tercel", MilesPerGallon = 38.1, AccelerationTime = 18.8, Cylinders = 4,
                    HorsePower = 60, Origin = "Japan", Weight = 1968
                },
                new Car()
                {
                    Model = "Chevrolet Chevette", MilesPerGallon = 32.1, AccelerationTime = 15.5, Cylinders = 4,
                    HorsePower = 70, Origin = "US", Weight = 2120
                },
                new Car()
                {
                    Model = "Datsun 310", MilesPerGallon = 37.2, AccelerationTime = 16.4, Cylinders = 4,
                    HorsePower = 65, Origin = "Japan", Weight = 2019
                },
                new Car()
                {
                    Model = "Chevrolet Citation", MilesPerGallon = 28, AccelerationTime = 16.5, Cylinders = 4,
                    HorsePower = 90, Origin = "US", Weight = 2678
                },
                new Car()
                {
                    Model = "Ford Fairmont", MilesPerGallon = 26.4, AccelerationTime = 18.1, Cylinders = 4,
                    HorsePower = 88, Origin = "US", Weight = 2870
                },
                new Car()
                {
                    Model = "AMC Concord", MilesPerGallon = 24.3, AccelerationTime = 20.1, Cylinders = 4,
                    HorsePower = 90, Origin = "US", Weight = 3003
                },
                new Car()
                {
                    Model = "Dodge Aspen", MilesPerGallon = 19.1, AccelerationTime = 18.7, Cylinders = 6,
                    HorsePower = 90, Origin = "US", Weight = 3381
                },
                new Car()
                {
                    Model = "Audi 4000", MilesPerGallon = 34.3, AccelerationTime = 15.8, Cylinders = 4, HorsePower = 78,
                    Origin = "Europe", Weight = 2188
                },
                new Car()
                {
                    Model = "Toyota Corolla Liftback", MilesPerGallon = 29.8, AccelerationTime = 15.5, Cylinders = 4,
                    HorsePower = 90, Origin = "Japan", Weight = 2711
                },
                new Car()
                {
                    Model = "Mazda 626", MilesPerGallon = 31.3, AccelerationTime = 17.5, Cylinders = 4, HorsePower = 75,
                    Origin = "Japan", Weight = 2542
                },
                new Car()
                {
                    Model = "Datsun 510 Hatchback", MilesPerGallon = 37, AccelerationTime = 15, Cylinders = 4,
                    HorsePower = 92, Origin = "Japan", Weight = 2434
                },
                new Car()
                {
                    Model = "Toyota Corolla", MilesPerGallon = 32.2, AccelerationTime = 15.2, Cylinders = 4,
                    HorsePower = 75, Origin = "Japan", Weight = 2265
                },
                new Car()
                {
                    Model = "Mazda GLC", MilesPerGallon = 46.6, AccelerationTime = 17.9, Cylinders = 4, HorsePower = 65,
                    Origin = "Japan", Weight = 2110
                },
                new Car()
                {
                    Model = "Dodge Colt", MilesPerGallon = 27.9, AccelerationTime = 14.4, Cylinders = 4,
                    HorsePower = 105, Origin = "US", Weight = 2800
                },
                new Car()
                {
                    Model = "Datsun 210", MilesPerGallon = 40.8, AccelerationTime = 19.2, Cylinders = 4,
                    HorsePower = 65, Origin = "Japan", Weight = 2110
                },
                new Car()
                {
                    Model = "Volkswagen Rabbit C (Diesel)", MilesPerGallon = 44.3, AccelerationTime = 21.7,
                    Cylinders = 4, HorsePower = 48, Origin = "Europe", Weight = 2085
                },
                new Car()
                {
                    Model = "Volkswagen Dasher (diesel)", MilesPerGallon = 43.4, AccelerationTime = 23.7, Cylinders = 4,
                    HorsePower = 48, Origin = "Europe", Weight = 2335
                },
                new Car()
                {
                    Model = "Audi 5000s (diesel)", MilesPerGallon = 36.4, AccelerationTime = 19.9, Cylinders = 5,
                    HorsePower = 67, Origin = "Europe", Weight = 2950
                },
                new Car()
                {
                    Model = "Mercedes-Benz 240d", MilesPerGallon = 30, AccelerationTime = 21.8, Cylinders = 4,
                    HorsePower = 67, Origin = "Europe", Weight = 3250
                },
                new Car()
                {
                    Model = "Honda Civic 1500 gl", MilesPerGallon = 44.6, AccelerationTime = 13.8, Cylinders = 4,
                    HorsePower = 67, Origin = "Japan", Weight = 1850
                },
                new Car()
                {
                    Model = "Renault Lecar Deluxe", MilesPerGallon = 40.9, AccelerationTime = 17.3, Cylinders = 4,
                    HorsePower = 0, Origin = "Europe", Weight = 1835
                },
                new Car()
                {
                    Model = "Subaru DL", MilesPerGallon = 33.8, AccelerationTime = 18, Cylinders = 4, HorsePower = 67,
                    Origin = "Japan", Weight = 2145
                },
                new Car()
                {
                    Model = "Volkswagen Rabbit", MilesPerGallon = 29.8, AccelerationTime = 15.3, Cylinders = 4,
                    HorsePower = 62, Origin = "Europe", Weight = 1845
                },
                new Car()
                {
                    Model = "Datsun 280-ZX", MilesPerGallon = 32.7, AccelerationTime = 11.4, Cylinders = 6,
                    HorsePower = 132, Origin = "Japan", Weight = 2910
                },
                new Car()
                {
                    Model = "Mazda RX-7 GS", MilesPerGallon = 23.7, AccelerationTime = 12.5, Cylinders = 3,
                    HorsePower = 100, Origin = "Japan", Weight = 2420
                },
                new Car()
                {
                    Model = "Triumph TR7 Coupe", MilesPerGallon = 35, AccelerationTime = 15.1, Cylinders = 4,
                    HorsePower = 88, Origin = "Europe", Weight = 2500
                },
                new Car()
                {
                    Model = "Ford Mustang Cobra", MilesPerGallon = 23.6, AccelerationTime = 14.3, Cylinders = 4,
                    HorsePower = 0, Origin = "US", Weight = 2905
                },
                new Car()
                {
                    Model = "Honda Accord", MilesPerGallon = 32.4, AccelerationTime = 17, Cylinders = 4,
                    HorsePower = 72, Origin = "Japan", Weight = 2290
                },
                new Car()
                {
                    Model = "Plymouth Reliant", MilesPerGallon = 27.2, AccelerationTime = 15.7, Cylinders = 4,
                    HorsePower = 84, Origin = "US", Weight = 2490
                },
                new Car()
                {
                    Model = "Buick Skylark", MilesPerGallon = 26.6, AccelerationTime = 16.4, Cylinders = 4,
                    HorsePower = 84, Origin = "US", Weight = 2635
                },
                new Car()
                {
                    Model = "Dodge Aries Wagon (sw)", MilesPerGallon = 25.8, AccelerationTime = 14.4, Cylinders = 4,
                    HorsePower = 92, Origin = "US", Weight = 2620
                },
                new Car()
                {
                    Model = "Chevrolet Citation", MilesPerGallon = 23.5, AccelerationTime = 12.6, Cylinders = 6,
                    HorsePower = 110, Origin = "US", Weight = 2725
                },
                new Car()
                {
                    Model = "Plymouth Reliant", MilesPerGallon = 30, AccelerationTime = 12.9, Cylinders = 4,
                    HorsePower = 84, Origin = "US", Weight = 2385
                },
                new Car()
                {
                    Model = "Toyota Starlet", MilesPerGallon = 39.1, AccelerationTime = 16.9, Cylinders = 4,
                    HorsePower = 58, Origin = "Japan", Weight = 1755
                },
                new Car()
                {
                    Model = "Plymouth Champ", MilesPerGallon = 39, AccelerationTime = 16.4, Cylinders = 4,
                    HorsePower = 64, Origin = "US", Weight = 1875
                },
                new Car()
                {
                    Model = "Honda Civic 1300", MilesPerGallon = 35.1, AccelerationTime = 16.1, Cylinders = 4,
                    HorsePower = 60, Origin = "Japan", Weight = 1760
                },
                new Car()
                {
                    Model = "Subaru", MilesPerGallon = 32.3, AccelerationTime = 17.8, Cylinders = 4, HorsePower = 67,
                    Origin = "Japan", Weight = 2065
                },
                new Car()
                {
                    Model = "Datsun 210 MPG", MilesPerGallon = 37, AccelerationTime = 19.4, Cylinders = 4,
                    HorsePower = 65, Origin = "Japan", Weight = 1975
                },
                new Car()
                {
                    Model = "Toyota Tercel", MilesPerGallon = 37.7, AccelerationTime = 17.3, Cylinders = 4,
                    HorsePower = 62, Origin = "Japan", Weight = 2050
                },
                new Car()
                {
                    Model = "Mazda GLC 4", MilesPerGallon = 34.1, AccelerationTime = 16, Cylinders = 4, HorsePower = 68,
                    Origin = "Japan", Weight = 1985
                },
                new Car()
                {
                    Model = "Plymouth Horizon 4", MilesPerGallon = 34.7, AccelerationTime = 14.9, Cylinders = 4,
                    HorsePower = 63, Origin = "US", Weight = 2215
                },
                new Car()
                {
                    Model = "Ford Escort 4W", MilesPerGallon = 34.4, AccelerationTime = 16.2, Cylinders = 4,
                    HorsePower = 65, Origin = "US", Weight = 2045
                },
                new Car()
                {
                    Model = "Ford Escort 2H", MilesPerGallon = 29.9, AccelerationTime = 20.7, Cylinders = 4,
                    HorsePower = 65, Origin = "US", Weight = 2380
                },
                new Car()
                {
                    Model = "Volkswagen Jetta", MilesPerGallon = 33, AccelerationTime = 14.2, Cylinders = 4,
                    HorsePower = 74, Origin = "Europe", Weight = 2190
                },
                new Car()
                {
                    Model = "Renault 18i", MilesPerGallon = 34.5, AccelerationTime = 15.8, Cylinders = 4,
                    HorsePower = 0, Origin = "Europe", Weight = 2320
                },
                new Car()
                {
                    Model = "Honda Prelude", MilesPerGallon = 33.7, AccelerationTime = 14.4, Cylinders = 4,
                    HorsePower = 75, Origin = "Japan", Weight = 2210
                },
                new Car()
                {
                    Model = "Toyota Corolla", MilesPerGallon = 32.4, AccelerationTime = 16.8, Cylinders = 4,
                    HorsePower = 75, Origin = "Japan", Weight = 2350
                },
                new Car()
                {
                    Model = "Datsun 200SX", MilesPerGallon = 32.9, AccelerationTime = 14.8, Cylinders = 4,
                    HorsePower = 100, Origin = "Japan", Weight = 2615
                },
                new Car()
                {
                    Model = "Mazda 626", MilesPerGallon = 31.6, AccelerationTime = 18.3, Cylinders = 4, HorsePower = 74,
                    Origin = "Japan", Weight = 2635
                },
                new Car()
                {
                    Model = "Peugeot 505s Turbo Diesel", MilesPerGallon = 28.1, AccelerationTime = 20.4, Cylinders = 4,
                    HorsePower = 80, Origin = "Europe", Weight = 3230
                },
                new Car()
                {
                    Model = "Saab 900s", MilesPerGallon = 0, AccelerationTime = 15.4, Cylinders = 4, HorsePower = 110,
                    Origin = "Europe", Weight = 2800
                },
                new Car()
                {
                    Model = "Volvo Diesel", MilesPerGallon = 30.7, AccelerationTime = 19.6, Cylinders = 6,
                    HorsePower = 76, Origin = "Europe", Weight = 3160
                },
                new Car()
                {
                    Model = "Toyota Cressida", MilesPerGallon = 25.4, AccelerationTime = 12.6, Cylinders = 6,
                    HorsePower = 116, Origin = "Japan", Weight = 2900
                },
                new Car()
                {
                    Model = "Datsun 810 Maxima", MilesPerGallon = 24.2, AccelerationTime = 13.8, Cylinders = 6,
                    HorsePower = 120, Origin = "Japan", Weight = 2930
                },
                new Car()
                {
                    Model = "Buick Century", MilesPerGallon = 22.4, AccelerationTime = 15.8, Cylinders = 6,
                    HorsePower = 110, Origin = "US", Weight = 3415
                },
                new Car()
                {
                    Model = "Oldsmobile Cutlass LS", MilesPerGallon = 26.6, AccelerationTime = 19, Cylinders = 8,
                    HorsePower = 105, Origin = "US", Weight = 3725
                },
                new Car()
                {
                    Model = "Ford Grenada gl", MilesPerGallon = 20.2, AccelerationTime = 17.1, Cylinders = 6,
                    HorsePower = 88, Origin = "US", Weight = 3060
                },
                new Car()
                {
                    Model = "Chrysler Lebaron Salon", MilesPerGallon = 17.6, AccelerationTime = 16.6, Cylinders = 6,
                    HorsePower = 85, Origin = "US", Weight = 3465
                },
                new Car()
                {
                    Model = "Chevrolet Cavalier", MilesPerGallon = 28, AccelerationTime = 19.6, Cylinders = 4,
                    HorsePower = 88, Origin = "US", Weight = 2605
                },
                new Car()
                {
                    Model = "Chevrolet Cavalier Wagon", MilesPerGallon = 27, AccelerationTime = 18.6, Cylinders = 4,
                    HorsePower = 88, Origin = "US", Weight = 2640
                },
                new Car()
                {
                    Model = "Chevrolet Cavalier 2-door", MilesPerGallon = 34, AccelerationTime = 18, Cylinders = 4,
                    HorsePower = 88, Origin = "US", Weight = 2395
                },
                new Car()
                {
                    Model = "Pontiac J2000 SE Hatchback", MilesPerGallon = 31, AccelerationTime = 16.2, Cylinders = 4,
                    HorsePower = 85, Origin = "US", Weight = 2575
                },
                new Car()
                {
                    Model = "Dodge Aries SE", MilesPerGallon = 29, AccelerationTime = 16, Cylinders = 4,
                    HorsePower = 84, Origin = "US", Weight = 2525
                },
                new Car()
                {
                    Model = "Pontiac Phoenix", MilesPerGallon = 27, AccelerationTime = 18, Cylinders = 4,
                    HorsePower = 90, Origin = "US", Weight = 2735
                },
                new Car()
                {
                    Model = "Ford Fairmont Futura", MilesPerGallon = 24, AccelerationTime = 16.4, Cylinders = 4,
                    HorsePower = 92, Origin = "US", Weight = 2865
                },
                new Car()
                {
                    Model = "AMC Concord DL", MilesPerGallon = 23, AccelerationTime = 20.5, Cylinders = 4,
                    HorsePower = 0, Origin = "US", Weight = 3035
                },
                new Car()
                {
                    Model = "Volkswagen Rabbit l", MilesPerGallon = 36, AccelerationTime = 15.3, Cylinders = 4,
                    HorsePower = 74, Origin = "Europe", Weight = 1980
                },
                new Car()
                {
                    Model = "Mazda GLC Custom l", MilesPerGallon = 37, AccelerationTime = 18.2, Cylinders = 4,
                    HorsePower = 68, Origin = "Japan", Weight = 2025
                },
                new Car()
                {
                    Model = "Mazda GLC Custom", MilesPerGallon = 31, AccelerationTime = 17.6, Cylinders = 4,
                    HorsePower = 68, Origin = "Japan", Weight = 1970
                },
                new Car()
                {
                    Model = "Plymouth Horizon Miser", MilesPerGallon = 38, AccelerationTime = 14.7, Cylinders = 4,
                    HorsePower = 63, Origin = "US", Weight = 2125
                },
                new Car()
                {
                    Model = "Mercury Lynx l", MilesPerGallon = 36, AccelerationTime = 17.3, Cylinders = 4,
                    HorsePower = 70, Origin = "US", Weight = 2125
                },
                new Car()
                {
                    Model = "Nissan Stanza XE", MilesPerGallon = 36, AccelerationTime = 14.5, Cylinders = 4,
                    HorsePower = 88, Origin = "Japan", Weight = 2160
                },
                new Car()
                {
                    Model = "Honda Accord", MilesPerGallon = 36, AccelerationTime = 14.5, Cylinders = 4,
                    HorsePower = 75, Origin = "Japan", Weight = 2205
                },
                new Car()
                {
                    Model = "Toyota Corolla", MilesPerGallon = 34, AccelerationTime = 16.9, Cylinders = 4,
                    HorsePower = 70, Origin = "Japan", Weight = 2245
                },
                new Car()
                {
                    Model = "Honda Civic", MilesPerGallon = 38, AccelerationTime = 15, Cylinders = 4, HorsePower = 67,
                    Origin = "Japan", Weight = 1965
                },
                new Car()
                {
                    Model = "Honda Civic (auto)", MilesPerGallon = 32, AccelerationTime = 15.7, Cylinders = 4,
                    HorsePower = 67, Origin = "Japan", Weight = 1965
                },
                new Car()
                {
                    Model = "Datsun 310 GX", MilesPerGallon = 38, AccelerationTime = 16.2, Cylinders = 4,
                    HorsePower = 67, Origin = "Japan", Weight = 1995
                },
                new Car()
                {
                    Model = "Buick Century Limited", MilesPerGallon = 25, AccelerationTime = 16.4, Cylinders = 6,
                    HorsePower = 110, Origin = "US", Weight = 2945
                },
                new Car()
                {
                    Model = "Oldsmobile Cutlass Ciera (diesel)", MilesPerGallon = 38, AccelerationTime = 17,
                    Cylinders = 6, HorsePower = 85, Origin = "US", Weight = 3015
                },
                new Car()
                {
                    Model = "Chrysler Lebaron Medallion", MilesPerGallon = 26, AccelerationTime = 14.5, Cylinders = 4,
                    HorsePower = 92, Origin = "US", Weight = 2585
                },
                new Car()
                {
                    Model = "Ford Grenada l", MilesPerGallon = 22, AccelerationTime = 14.7, Cylinders = 6,
                    HorsePower = 112, Origin = "US", Weight = 2835
                },
                new Car()
                {
                    Model = "Toyota Celica GT", MilesPerGallon = 32, AccelerationTime = 13.9, Cylinders = 4,
                    HorsePower = 96, Origin = "Japan", Weight = 2665
                },
                new Car()
                {
                    Model = "Dodge Charger 2.2", MilesPerGallon = 36, AccelerationTime = 13, Cylinders = 4,
                    HorsePower = 84, Origin = "US", Weight = 2370
                },
                new Car()
                {
                    Model = "Chevrolet Camaro", MilesPerGallon = 27, AccelerationTime = 17.3, Cylinders = 4,
                    HorsePower = 90, Origin = "US", Weight = 2950
                },
                new Car()
                {
                    Model = "Ford Mustang GL", MilesPerGallon = 27, AccelerationTime = 15.6, Cylinders = 4,
                    HorsePower = 86, Origin = "US", Weight = 2790
                },
                new Car()
                {
                    Model = "Volkswagen Pickup", MilesPerGallon = 44, AccelerationTime = 24.6, Cylinders = 4,
                    HorsePower = 52, Origin = "Europe", Weight = 2130
                },
                new Car()
                {
                    Model = "Dodge Rampage", MilesPerGallon = 32, AccelerationTime = 11.6, Cylinders = 4,
                    HorsePower = 84, Origin = "US", Weight = 2295
                },
                new Car()
                {
                    Model = "Ford Ranger", MilesPerGallon = 28, AccelerationTime = 18.6, Cylinders = 4, HorsePower = 79,
                    Origin = "US", Weight = 2625
                },
                new Car()
                {
                    Model = "Chevy S-10", MilesPerGallon = 31, AccelerationTime = 19.4, Cylinders = 4, HorsePower = 82,
                    Origin = "US", Weight = 2720
                },
            };
        }

        
    }
}

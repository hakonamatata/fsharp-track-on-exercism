module LuciansLusciousLasagna

let expectedMinutesInOven = 40

let remainingMinutesInOven minInOven = expectedMinutesInOven - minInOven

let preparationTimeInMinutes layers = layers * 2

let elapsedTimeInMinutes layers minInOven = preparationTimeInMinutes layers + minInOven

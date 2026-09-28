_PyshicsProcess ir cikls, kas paradzēts kustībai, jo tas izpildās ar noteiktu fiksētu laika intervālu.

60Hz: delta  = 1/60 ~ 0.0167s (Pārbīde vienam kadram ir ~ 200 x 0.0167 = 3.33... px)
30Hz: delta = 1/30 ~ 0.0333s (Pārbīde vienam kadram ir ~ 200 x 0.0333 = 6.67px)

bez (float)delta 
Pie 30Hz: tainst. virzās uz priekšu pa 200px ik pa 30 kadriem; 30 x 200 = 6000px/s
Pie 60Hz: tainst. virzās uz priekšu pa 200 px ik pa 60 kadriem; 60 x 200 = 12000px/s

bez delta ātrums ir atkarīgs no kadru skaita.

Kodā reizināšana ar delta nodrošina to, ka taisnst. pārvietojas ar vienmērīgu reāllaika ātrumu neatkarīgi no tā cik kadus sek. spēle izpilda.


2.3

Garums = D + S = √1^2+1^2 = √2 ~ 1.41 (41% ātrāk)

1. Bez .Normalized() tainsstūris pa diagonāli kustas par aptuveni 41.4% ātrāk. Izmantojot .Normalized(), vektora garums tiek saīsināts līdz 1.0, saglabājot vienmērīgu ātrumu visos virzienos.

2. Godot funkcija MoveAndSlide() jau pati automātiski reizina Velocity (ātrumu) ar kadru laika starpību (delta). Ja reizina to otreiz tad kustība kļūst par lēnu.

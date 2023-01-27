<template>
   <div class="container">
    <div class="row">
      <div class="col">
        <h1 class="text-center">Bemutatkozó</h1>
        <p>3 lelkes, vállalkozó szellemű fiatal csapat áll a hátterében a vásárnak, célunk az emberek öröme. Jogos kérdés merülhet fel, hogy miért pont a nyaralás?</p>
        <p>A turizmusban, ha az utazás célját nézzük, két fő típus létezik: a hivatásturizmus valamint a szabadidőturizmus. Nem árulok el túl nagy titkot azzal, hogy a hivatásturizmus a munka világát érinti - ide tartoznak az üzleti utak, kongresszusok, kiállítások, diplomáciai- és tanulmányutak -, míg a szabadidőturizmus minden mást, elsősorban a vakáció, a pihenőidő, a szünidő, a szabadság kellemes, otthontól távoli eltöltését szolgálja. Egy egyszerű nyaraláson ismerkedett meg a csapat, és innen kezdődött minden...</p> 
      <div class="row">
        <div class="col d-flex justify-content-center">
          <img src="/utazas.jpg" alt="utazasi kep" style="border-radius: 50px; margin-bottom: 10px; width: 700px;" class="img-fluid">
        </div>
        
      </div>
        <p>A 2020-as év történései, a pandémia és a kormányok védekező reakciója, miszerint egyre több ország zárta be kapuit a turisták elől, hogy így akadályozzák meg a vírus terjedését, arra késztettek, hogy végig gondoljam, számomra mit is jelent igazából az utazás, és miért érzem ennek ellehetetlenítését egyre aggasztóbb világjelenségnek a Covid-19 2020-as kitörése óta? Az utazás évezredek óta az emberiség működésének része, a hajtóereje. Ha nincsenek például a hódító arabok, vagy a kalandvágyó magyarok ősei, ha nincsenek a vikingek, ha nincsen Kolumbusz Kristóf és Magellán, ha nincsen az a sok tettre kész, szinte őrülten elszánt, névtelen tengerész és kevésbé ismert megannyi szárazföldi felfedező, akik sokszor életük árán is menni akartak, megismerni új világokat, meghódítani új földeket, nem is tudom… talán még mindig azt gondolnánk, hogy a Föld lapos... Az utazás szerintem elidegeníthetetlen része a fejlődésnek. Persze vannak olyan emberek, akik inkább a biztonságot adó otthonukat és a már megismert, kipróbált közeli helyeket szeretik, vagy csak egyszerűen nem vágynak arra, hogy messzi tájakat hódítsanak meg, mert ők így érzik jól magukat a saját környezetükben. És ez teljesen rendben is van így! Nem lehet mindenki felfedező, nem lehet mindenki utazó!</p> 
      </div>
    </div>
    <div class="row d-flex justify-content-center" style="margin-bottom: 20px; margin-top: 0px;">
      <div class="col-lg-3">
          <div class="card p-0">
              <div class="card-image">
                  <img src="/dao.jpg"
                      alt="Dao László profilképe">
              </div>
              <div class="card-content d-flex flex-column align-items-center">
                  <h4 class="pt-2">Dao László</h4>
                  <h5>Tulajdonos és weboldal dizájner</h5>

                  <ul class="social-icons d-flex justify-content-center">
                      <li style="--i:1">
                          <a href="https://www.facebook.com/NiGhtMaRRRRRRRe" target="_blank">
                              <span class="fab fa-facebook"></span>
                          </a>
                      </li>
                      <li style="--i:2">
                          <a href="https://www.instagram.com/lac1_1/">
                              <span class="fab fa-instagram"></span>
                          </a>
                      </li>
                  </ul>
              </div>
          </div>
      </div>
      <div class="col-lg-3">
        <div class="card p-0">
            <div class="card-image">
                <img src="/huszar.jpg"
                    alt="Huszár Botond profilképe">
            </div>
            <div class="card-content d-flex flex-column align-items-center">
                <h4 class="pt-2">Huszár Botond</h4>
                <h5>Helyettes és weboldal dizájner</h5>

                <ul class="social-icons d-flex justify-content-center">
                    <li style="--i:1">
                        <a href="https://www.facebook.com/profile.php?id=100005288409534" target="_blank">
                            <span class="fab fa-facebook"></span>
                        </a>
                    </li>
                    <li style="--i:2">
                        <a href="https://www.instagram.com/botihuszar/" target="_blank">
                            <span class="fab fa-instagram"></span>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
      <div class="col-lg-3">
          <div class="card p-0">
              <div class="card-image">
                  <img src="/magyari.jpg"
                      alt="Magyari Levente profilképe">
              </div>
              <div class="card-content d-flex flex-column align-items-center">
                  <h4 class="pt-2">Magyari Levente</h4>
                  <h5>Üzlettervező és számviteli menedzser</h5>

                  <ul class="social-icons d-flex justify-content-center">
                      <li style="--i:1">
                          <a href="https://www.facebook.com/levente.magyari.96" target="_blank">
                              <span class="fab fa-facebook"></span>
                          </a>
                      </li>
                  </ul>
              </div>
          </div>
      </div>
  </div>
  </div>

</template>

<style>
.card {
    position: relative;
    padding: 0;
    margin: 0 !important;
    border-radius: 20px;
    overflow: hidden;
    max-width: 280px;
    max-height: 340px;
    cursor: pointer;
    border: none;
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.2);
    border-radius: 150px !important;
}

.card .card-image {
    width: 100%;
    max-height: 340px;
}

.card .card-image img {
    width: 100%;
    max-height: 340px;
    object-fit: cover;
}

.card .card-content {
    position: absolute;
    bottom: -180px;
    color: #fff;
    background: rgba(255, 255, 255, 0.2);
    backdrop-filter: blur(15px);
    min-height: 140px;
    width: 100%;
    transition: bottom .4s ease-in;
    box-shadow: 0 -10px 10px rgba(255, 255, 255, 0.1);
    border-top: 1px solid rgba(255, 255, 255, 0.2);
}

.card:hover .card-content {
    bottom: 0px;
}

.card:hover .card-content h4,
.card:hover .card-content h5 {
    transform: translateY(10px);
    opacity: 1;
}

.card .card-content h4,
.card .card-content h5 {
    font-size: 1.1rem;
    text-transform: uppercase;
    letter-spacing: 3px;
    text-align: center;
    transition: 0.8s;
    font-weight: 500;
    opacity: 0;
    transform: translateY(-40px);
    transition-delay: 0.2s;
}

.card .card-content h5 {
    transition: 0.5s;
    font-weight: 200;
    font-size: 0.8rem;
    letter-spacing: 2px;
}

.card .card-content .social-icons {
    list-style: none;
    padding: 0;
}


.card .card-content .social-icons li {
    margin: 10px;
    transition: 0.5s;
    transition-delay: calc(0.15s * var(--i));
    transform: translateY(50px);
}


.card:hover .card-content .social-icons li {
    transform: translateY(20px);
}

.card .card-content .social-icons li a {
    color: #fff;
}

.card .card-content .social-icons li a span {
    font-size: 1.3rem;
}
</style>

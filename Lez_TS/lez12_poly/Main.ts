import Animale from "./Animale";
import Cane from "./Cane";
import Gatto from "./Gatto";

// function verso( ani: Animale ){
//     ani.versoEmesso();
// }

// verso( new Gatto("Bu", true) );
// verso( new Gatto("Bah", true) );
// verso( new Cane("Bubba", true) );

// -----------------------------------------------------------

let bu : Animale = new Gatto("Bu", true);
let xi : Animale = new Gatto("Xi", false);
let xiu : Animale = new Cane("Xi", true);

// bu.versoEmesso();
// xi.versoEmesso();
// xiu.versoEmesso();

let elenco : Animale[] = new Array();
elenco.push(bu);
elenco.push(xi);
elenco.push(xiu);

elenco.forEach(element => {
    element.versoEmesso();

    if(element instanceof Gatto){
        element.faFusa()
    }
});


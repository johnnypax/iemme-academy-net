import Albergo from "./Albergo";
import Camera from "./Camera";

let alb = new Albergo("Piazza la bomba e scappa");

alb.aggiungiCamera( new Camera("101") );
alb.aggiungiCamera( new Camera("102") );
alb.aggiungiCamera( new Camera("103") );
alb.aggiungiCamera( new Camera("104") );

alb.stampaAlbergo();
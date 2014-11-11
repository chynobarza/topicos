package com.example.javier.prueba1;

/**
 * Created by JAVIER on 10/11/2014.
 */
import android.graphics.Color;

import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.PolygonOptions;
import com.google.android.gms.maps.model.Polyline;
import com.google.android.gms.maps.model.PolylineOptions;


public class Posiciones {
    //public static final LatLng SAGRADA_FAMILIA = new LatLng(41.40347, 2.17432);
    //Constante de Opciones de Polilínea.

    public static final PolylineOptions POLILINEA1 = new PolylineOptions()
            .color(Color.RED)
            .add(new LatLng(19.398237,-99.200363))
            .add(new LatLng(19.403439,-99.187102 ))
            .add(new LatLng (19.41289,-99.182167))
            .add(new LatLng (19.42083,-99.176943))
            .add(new LatLng (19.421916,-99.17058))
            .add(new LatLng(19.423292,-99.163177))
            .add(new LatLng(19.425862,-99.154701))
            .add(new LatLng (19.42744,-99.149036))
            .add(new LatLng(19.426813,-99.142213))
            .add(new LatLng(19.426732,-99.137685))
            .add(new LatLng(19.425336,-99.132943))
            .add(new LatLng(19.425558,-99.124639))
            .add(new LatLng(19.428837,-99.119511))
            .add(new LatLng(19.430213,-99.114833))
            .add(new LatLng(19.427218,-99.110305))
            .add(new LatLng(19.423231,-99.102302))
            .add(new LatLng (19.41967,-99.09595))
            .add(new LatLng (19.416472,-99.09035))
            .add(new LatLng (19.412344,-99.08241))
            .add(new LatLng(19.415359,-99.072132));
    //        .strokeColor(Color.GREEN)
      //      .fillColor(Color.BLUE);
    public static final PolylineOptions POLILINEA2 = new PolylineOptions()
            .color(Color.BLUE)
            .add (new LatLng (19.459592,-99.215899))
            .add (new LatLng (19.458763,-99.203153))
            .add (new LatLng (19.459349,-99.189205))
            .add (new LatLng (19.457448,-99.182038))
            .add (new LatLng (19.452147,-99.1747))
            .add (new LatLng (19.449354,-99.172254))
            .add (new LatLng (19.4444,-99.1674))
            .add (new LatLng (19.441706,-99.161096))
            .add (new LatLng (19.441706,-99.161096))
            .add (new LatLng (19.437295,-99.147105))
            .add (new LatLng (19.436243,-99.141945))
            .add (new LatLng (19.435514,-99.137406))
            .add (new LatLng (19.433248,-99.1329))
            .add (new LatLng (19.425336,-99.132943))
            .add (new LatLng (19.418597,-99.134145))
            .add (new LatLng (19.406438,-99.135754))
            .add (new LatLng (19.400808,-99.136891))
            .add (new LatLng (19.3952,-99.1377))
            .add (new LatLng (19.38753,-99.138994))
            .add (new LatLng (19.379474,-99.140217))
            .add (new LatLng (19.3698,-99.1416))
            .add (new LatLng (19.361883,-99.142942))
            .add (new LatLng (19.353259,-99.145002))
            .add (new LatLng (19.344168,-99.142685));

    public static final PolygonOptions POLIGONO = new PolygonOptions()
            .add(new LatLng(19.398237,-99.200363),
                    new LatLng (19.403439,-99.187102),
                    new LatLng (19.41289,-99.182167),
                    new LatLng (19.42083,-99.176943),
                    new LatLng (19.421916,-99.17058),
                    new LatLng(19.423292,-99.163177),
                    new LatLng(19.425862,-99.154701),
                    new LatLng (19.42744,-99.149036),
                    new LatLng(19.426813,-99.142213),
                    new LatLng(19.426732,-99.137685),
                    new LatLng(19.425336,-99.132943),
                    new LatLng(19.425558,-99.124639),
                    new LatLng(19.428837,-99.119511),
                    new LatLng(19.430213,-99.114833),
                    new LatLng(19.427218,-99.110305),
                    new LatLng(19.423231,-99.102302),
                    new LatLng (19.41967,-99.09595),
                    new LatLng (19.416472,-99.09035),
                    new LatLng (19.412344,-99.08241),
                    new LatLng(19.415359,-99.072132))
            .strokeColor(Color.RED);


}

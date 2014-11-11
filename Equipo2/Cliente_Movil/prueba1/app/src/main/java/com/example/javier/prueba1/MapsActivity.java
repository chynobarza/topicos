package com.example.javier.prueba1;

import android.location.Location;
import android.support.v4.app.FragmentActivity;
import android.os.Bundle;
import android.util.Log;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.UiSettings;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.Marker;
import com.google.android.gms.maps.model.MarkerOptions;
import com.google.android.gms.maps.model.Polygon;
import com.google.android.gms.maps.model.PolygonOptions;
import com.google.android.gms.maps.model.Polyline;
import com.google.android.gms.maps.model.PolylineOptions;


public class MapsActivity extends FragmentActivity {

    public GoogleMap mMap; // Might be null if Google Play services APK is not available.
    private final LatLng UPV=new LatLng(19.398237,-99.200363);
    //public static final LatLng SAGRADA_FAMILIA = new LatLng(41.40347, 2.17432);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_maps);
        setUpMapIfNeeded();
        mMap.moveCamera(CameraUpdateFactory.newLatLngZoom(UPV, 12));
        mMap.setMyLocationEnabled(true);
        mMap.getUiSettings().setZoomControlsEnabled(false);
        mMap.getUiSettings().setCompassEnabled(true);
        drawPolilyne(Posiciones.POLILINEA1);
        drawPolilyne(Posiciones.POLILINEA2);
        

//        drawPoligono(Posiciones.POLIGONO);




    }

    @Override
    protected void onResume() {
        super.onResume();
        setUpMapIfNeeded();
    }

    /**
     * Sets up the map if it is possible to do so (i.e., the Google Play services APK is correctly
     * installed) and the map has not already been instantiated.. This will ensure that we only ever
     * call {@link #setUpMap()} once when {@link #mMap} is not null.
     * <p>
     * If it isn't installed {@link SupportMapFragment} (and
     * {@link com.google.android.gms.maps.MapView MapView}) will show a prompt for the user to
     * install/update the Google Play services APK on their device.
     * <p>
     * A user can return to this FragmentActivity after following the prompt and correctly
     * installing/updating/enabling the Google Play services. Since the FragmentActivity may not
     * have been completely destroyed during this process (it is likely that it would only be
     * stopped or paused), {@link #onCreate(Bundle)} may not be called again so we should call this
     * method in {@link #onResume()} to guarantee that it will be called.
     */
    private void setUpMapIfNeeded() {
        // Do a null check to confirm that we have not already instantiated the map.
        if (mMap == null) {
            // Try to obtain the map from the SupportMapFragment.
            mMap = ((SupportMapFragment) getSupportFragmentManager().findFragmentById(R.id.map))
                    .getMap();
            // Check if we were successful in obtaining the map.
            if (mMap != null) {
                setUpMap();
            }
        }
    }

    /**
     * This is where we can add markers or lines, add listeners or move the camera. In this case, we
     * just add a marker near Africa.
     * <p>
     * This should only be called once and when we are sure that {@link #mMap} is not null.
     */


    private void setMarker(LatLng position, String titulo, String info) {
        // Agregamos marcadores para indicar sitios de interéses.
        Marker myMaker = mMap.addMarker(new MarkerOptions()
                .position(position)
                .title(titulo)  //Agrega un titulo al marcador
                .snippet(info)   //Agrega información detalle relacionada con el marcador
                .icon(BitmapDescriptorFactory.defaultMarker(BitmapDescriptorFactory.HUE_GREEN))); //Color del marcador

    }

    //Declaramos una constante global en la clase MainActivity con las coordenadas del marcador.


    private void drawPolilyne(PolylineOptions options){
        Polyline polyline = mMap.addPolyline(options);
    }
    private void drawPoligono(PolygonOptions opts){
        Polygon poligono = mMap.addPolygon(opts);
    }

    private void setUpMap() {

        mMap.addMarker(new MarkerOptions().position(new LatLng(19.398237,-99.200363)).title("Estas Aqui!!!"));
        mMap.setMyLocationEnabled(true);

//        mMap.animateCamera(CameraUpdateFactory.zoomTo(44));


    }
    public class ClickListener implements GoogleMap.OnMapClickListener {
        @Override
        public void onMapClick(LatLng latLong) {
            Log.v("ClickListener latitude: ", String.valueOf(latLong.latitude));
            Log.v("ClickListener longitude: ", String.valueOf(latLong.longitude));
        }

        public class ClickLongListener implements GoogleMap.OnMapLongClickListener {
            @Override
            public void onMapLongClick(LatLng latLong) {
                Log.v("ClickLongListener latitude: ", String.valueOf(latLong.latitude));
                Log.v("ClickLongListener longitude: ", String.valueOf(latLong.longitude));
            }

            private void addClickLongListener() {
                mMap.setOnMapLongClickListener(new ClickLongListener());
            }
        }


    }
}









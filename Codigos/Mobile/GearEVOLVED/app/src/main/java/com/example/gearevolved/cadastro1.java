package com.example.gearevolved;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class cadastro1 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cadastro1);
    }
    public void CadOnClick(View v){
        Intent Intent = new Intent(getApplicationContext(), Cadastro2.class);
        startActivity(Intent);
    }
}
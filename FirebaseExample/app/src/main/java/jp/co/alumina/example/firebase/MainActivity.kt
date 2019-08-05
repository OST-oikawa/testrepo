package jp.co.alumina.example.firebase

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val textConsole : TextView = this.findViewById(R.id.textConsole)

        textConsole.text = "あいうえお"
    }
}

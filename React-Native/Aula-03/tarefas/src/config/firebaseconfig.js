import * as firebase from 'firebase';
import '@firebase/auth';
import '@firebase/firestore';

const firebaseConfig = {
    apiKey: "AIzaSyCGGt_5B112s-53YgdYEdi4RSStwaVtESQ",
    authDomain: "persistencia-native-recode.firebaseapp.com",
    projectId: "persistencia-native-recode",
    storageBucket: "persistencia-native-recode.appspot.com",
    messagingSenderId: "720445829813",
    appId: "1:720445829813:web:50ec907d1dc41d954b04fc",
    measurementId: "G-MEW98LEQ70"
};

if (!firebase.apps.length) {
    firebase.initializeApp(firebaseConfig);
}

const database = firebase.firestore();
export default database;
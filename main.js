import "./style.css";
import { initializeApp } from "firebase/app";
import { getDatabase, ref, set, onValue } from "firebase/database";

const firebaseConfig = {
  apiKey: "AIzaSyByexE_lj6I5yKEogQqwdqqHzYPiFac5nY",
  authDomain: "crud-firebase-67d8a.firebaseapp.com",
  databaseURL: "https://crud-firebase-67d8a-default-rtdb.firebaseio.com",
  projectId: "crud-firebase-67d8a",
  storageBucket: "crud-firebase-67d8a.appspot.com",
  messagingSenderId: "820769110341",
  appId: "1:820769110341:web:59c107aad828304f60e62c",
  measurementId: "G-ZH459T7RRZ",
};

const firebaseApp = initializeApp(firebaseConfig);
const database = getDatabase(firebaseApp);
const dataContacts = ref(database, "contacts"); // Reemplaza 'ruta_de_tu_datos' con la ruta de tus datos en la base de datos.

const tableContacts = document.getElementById("tableContacts");

onValue(dataContacts, (snapshot) => {
  const contactData = snapshot.val();

  // Limpia la tabla antes de agregar datos nuevos.
  tableContacts.innerHTML = "";

  for (const contactId in contactData) {
    if (contactData.hasOwnProperty(contactId)) {
      const contact = contactData[contactId];
      const row = document.createElement("tr");
      row.innerHTML = `
                <td>${contact.name}</td>
                <td>${contact.age}</td>
                <td>${contact.address}</td>
                <td>${contact.phone}</td>
                <td><button class="btn btn-success">Edit</button></td>
                <td><button class="btn btn-danger">Delete</button></td>
            `;
      tableContacts.appendChild(row);
    }
  }
});

const contactForm = document.getElementById("contact-form");
contactForm.addEventListener("submit", (e) => {
  e.preventDefault();

  const name = contactForm.name.value;
  const age = contactForm.age.value;
  const address = contactForm.address.value;
  const phone = contactForm.phone_number.value;

  // Agregar el nuevo usuario a la base de datos
  set(ref(dataContacts, name), {
    name: name,
    age: age,
    address: address,
    phone: phone,
  })
    .then(() => {
      alert("Contacto agregado correctamente");
      contactForm.reset(); // Limpiar el formulario
    })
    .catch((error) => {
      console.error("Error al agregar contacto:", error);
    });
});

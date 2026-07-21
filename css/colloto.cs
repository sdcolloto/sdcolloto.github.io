:root {
  --bs-green: #00b647;
}
    
/* ======== SUBMENÚ CON EL MISMO DISEÑO ======== */

/* Fondo del dropdown igual que el navbar */
.dropdown-menu {
    background-color: var(--verde);   /* tu color verde */
    border: none;
    padding: 0;
}

/* Items del submenú */
.dropdown-item {
    color: var(--blanco);             /* texto blanco */
    padding: 0.75rem 1rem;
    font-weight: 600;
    text-transform: uppercase;
}

/* Hover igual que el menú principal */
.dropdown-item:hover {
    background-color: var(--verde-oscuro);  /* tono más oscuro */
    color: var(--gris);                     /* igual que tu hover */
}

/* Mostrar el submenú al pasar el ratón */
.nav-item.dropdown:hover .dropdown-menu {
    display: block;
    margin-top: 0;
}

/* ========= FONDO VERDE ========================*/


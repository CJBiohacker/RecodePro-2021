import styles from '../styles/Home.module.css'

export default function pagina2() {
    let subtext = <sub>sub texto</sub>;
    let suptext = "texto superior";

    return (
        <div>
            <h3>Título</h3>
            <p>Página customizada processada pelo framework NextJS</p>
            <div className={styles.flexContainer}>
                <p>
                    {subtext}
                    Texto
                    <sup>{suptext}</sup>
                </p>
            </div>
        </div>
    )
}
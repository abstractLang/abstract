import styles from "./under-development.module.css";

export default function UnderDevelopmentBanner(): JSX.Element {

    return (
        <div className={styles.warningBar}>
            <b>Attention:</b> This Website and Tool are still under development!
        </div>
    );

}
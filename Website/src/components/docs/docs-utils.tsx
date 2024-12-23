import styles from './doc-utils.module.css';

export function Funcdoc({children, bookmark}): JSX.Element {
    return (<div className={styles.funcdoc} id={bookmark}>{children}</div>);
}
export function FuncdocParam({children, type, name}): JSX.Element {

    let isreturn = name == "!ret";

    return (
        <div className={styles.funcdocParams}>

            {!isreturn && <p className={styles.identifier}>
                <span className={styles.type}>{type}</span> <span className={styles.name}>{name}</span>:
            </p>}

            {isreturn && <p className={styles.identifier}>
                <span className={styles.name}>returns</span> <span className={styles.type}>{type}</span>:
            </p>}
            
            <div>{children}</div>
        </div>
    );

}

export function Fielddoc({children, bookmark}): JSX.Element {
    return (<div className={styles.fielddoc} id={bookmark}>{children}</div>);
}
export function FielddocStores({children, type}): JSX.Element {
    return (
        <div className={styles.fielddocStores}>
            <p className={styles.identifier}>
                <span className={styles.name}>stores</span> <span className={styles.type}>{type}</span>:
            </p>
            <div>{children}</div>
        </div>
    );
}

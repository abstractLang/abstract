import clsx from 'clsx';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import Layout from '@theme/Layout';
import Heading from '@theme/Heading';

import styles from './index.module.css';
import UnderDevelopmentBanner from '../components/under-development/under-development';

function HomepageHeader() {
  const {siteConfig} = useDocusaurusContext();

  return (
    <header className={clsx('hero hero--primary', styles.heroBanner)}>
      <div className="container">
        <Heading as="h1" className="hero__title">
          ABSTRACT
        </Heading>
        <p className="hero__subtitle">Programming language</p>
      </div>
    </header>
  );
}

export default function Home(): JSX.Element {
  const {siteConfig} = useDocusaurusContext();
  return (
    <Layout
      title={`${siteConfig.title}`}
      description="">
      
      <UnderDevelopmentBanner></UnderDevelopmentBanner>

      <HomepageHeader />
      <main className={styles.warning}>
        Warning! <br/>
        This website is still under development! <br/>
        Get more information or help us to improve this page
        on github.
      </main>
    </Layout>
  );
}

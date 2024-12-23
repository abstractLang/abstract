import React from 'react';
import DefaultAdmonitionTypes from '@theme-original/Admonition/Types';
import './admonitions.css';

function NotImplemented(_) {
  return (
    <div className="not-implemented warning">
      <h1>This feature is still not implemented!</h1>
    </div>
  );
}

function UnderConstruction(_) {
  return (
    <div className="under-construction warning">
      <h1>This page is still under construction!</h1>
    </div>
  );
}

const AdmonitionTypes = {
  ...DefaultAdmonitionTypes,

  'not-implemented': NotImplemented,
  'under-construction': UnderConstruction,
};

export default AdmonitionTypes;

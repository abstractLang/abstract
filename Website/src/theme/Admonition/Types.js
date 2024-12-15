import React from 'react';
import DefaultAdmonitionTypes from '@theme-original/Admonition/Types';
import './admonitions.css';

function FuncDoc(props) {

  let id = "";
  if (props.title) id = props.title;

  return (
    <div id={id} className="funcdoc">
      <div>{props.children}</div>
    </div>
  );
}

function FuncDocParams(props) {
  
  let ptype = props.title.split(' ')[0];
  let pname = props.title.split(' ')[1];
  let isReturn = pname == "!ret";

  return (
    <div className="funcdoc-params">
      <p className="identifier">
        {isReturn && <span><span className="name">returns</span> <span className="type">{ptype}</span>:</span> }
        {!isReturn && <span><span className="type">{ptype}</span> <span className="name">{pname}</span>:</span> }
      </p>
      <div className="description">{props.children}</div>
    </div>
  );
}

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
  'funcdoc': FuncDoc,
  'funcdoc-params': FuncDocParams,
  'not-implemented': NotImplemented,
  'under-construction': UnderConstruction,
};

export default AdmonitionTypes;

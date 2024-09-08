import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import HelloWorld from './components/HelloWorld';
import ReactJSX from './components/ReactJSX';
import ExpressionReact from './components/ExpressionReact';
import Attribute from './components/Attribute';
import MaterialUI from './components/MaterialUI';

const root = ReactDOM.createRoot(document.getElementById('root'));

//Creating Element
const element = <h1>Hello, world</h1>;

var ele2 = <h1>Hello MJ</h1>

root.render(
  <React.StrictMode>

   {/*  <App /> */}
   {/* <HelloWorld/> */}
   {/* <ReactJSX/> */}
   {/* <ExpressionReact/> */}
   {/* <Attribute/> */}
   <MaterialUI/>

  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();

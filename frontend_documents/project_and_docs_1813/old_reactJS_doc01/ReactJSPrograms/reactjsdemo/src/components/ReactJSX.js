import React from "react"

//Assign to Variable
var ele23 = <h1>Assign To Variable</h1>


//Assign to a variable based on a condition.
var elecond = true;
var elecone = false;
var ele24;
var ele25;
if(elecond){
    ele24 = <h3>I Got Ya ele24</h3>;
}else{
    ele24 = <h3>NA 1</h3>
}
if(elecone){
    ele25 = <h5>I got Ya ele24</h5>
}else{
    ele25 = <h5>NA 2</h5>
}


class ReactJSX extends React.Component{
   render(){
    return(
        <div>
            <table>
               <tr>
                   <th>Number</th>
                   <th>Topic</th>
                   <th>Details</th>
               </tr>
               <tr>
                    <td>1</td>
                    <td>Assign to a variable.</td>
                    <td>
                        {/* Expression */}
                        {ele23}
                    </td>
               </tr>
               <tr>
                    <td>2</td>
                    <td>Assign to a variable based on a condition..</td>
                    <td>
                        True : {ele24}
                        False : {ele25}
                    </td>
               </tr>
            </table>
        </div>
    );
   }
}

export default ReactJSX;
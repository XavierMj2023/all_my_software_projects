import React from "react";

var cTime = new Date().toTimeString();

class ExpressionReact extends React.Component{
    render(){
        return(
            <div>
                <p>The Current Time/Date is : {cTime}</p>
            </div>
        );
    }
}

export default ExpressionReact;
import React from "react";

var blue = "blue";

function getCurrentTime(){
    return new Date().toTimeString();
}

//Here className is Attribute JSX

//Second example is Using Expression within Attributes

class Attribute extends React.Component{
    render(){
        return(
            <div>
                <p>
                    <span className="red">
                        The Current Time/Date is : {getCurrentTime()}
                    </span>
                </p>
                <p>
                    <span className={blue}>
                        The Current Time/Date is : {getCurrentTime()}
                    </span>
                </p>
            </div>
        );
    }
}

export default Attribute;
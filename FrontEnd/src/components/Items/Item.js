import 'bootstrap/dist/css/bootstrap.min.css';
import Home from '../Home/Home';
import classes from './items.module.css';
import UsersSummary from '../Users/UsersSummary';
import { Fragment } from 'react';






const Item = () =>{
  
    return(
    <Fragment>
        <Home />
        <br>

        </br>

        <UsersSummary />
        </Fragment>
    );
}

export default Item;
import { useEffect, useState } from 'react'
import * as techService from '../apiController/technologyService.js';

export const Data = () => {

    const [tech, setTech] = useState([]);

    useEffect(() => {
        techService.getAll()
            .then(tech =>setTech(tech));
     
    }, []);

    console.log(tech);
    return (
        <h1> OK</h1>
    );
};


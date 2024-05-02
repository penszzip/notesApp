import React, { useEffect, useState } from 'react'
import Note from './Note';

const Notes = () => {
    // const [notes, setNotes] = useState([]);

    // useEffect(() => {
    //     const fetchNotes = async () => {
    //         fetch("http://localhost:5111/api/notes")
    //             .then(response => {
    //                 if (!response.ok) {
    //                     throw new Error(`HTTP error! status: ${response.status}`);
    //                 }
    //                 return response.json();
    //             })
    //             .then(data => console.log(data))
    //             .catch(error => console.log('There was a problem with the fetch operation: ' + error.message));
    //     }
    //     fetchNotes()
    // }, [])

    return (
        <div className='notes-list'>
            <Note />
            <Note />
            <Note />
            <Note />
        </div>
    )
}

export default Notes;
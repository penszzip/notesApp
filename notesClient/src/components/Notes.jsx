import React, { useEffect, useState } from 'react'
import Note from './Note';
import AddNote from './AddNote';
import { nanoid } from 'nanoid'

const Notes = () => {
    const [notes, setNotes] = useState([
        {
            id: 1,
            text: 'This is a note!',
            date: '15/04/2024',
        },
        {
            id: 2,
            text: 'This is a note!',
            date: '17/04/2024',
        },
        {
            id: 3,
            text: 'This is a note!',
            date: '19/04/2024',
        },
        {
            id: 4,
            text: 'This is a note!',
            date: '20/04/2024',
        },
        {
            id: 5,
            text: 'This is a note!',
            date: '21/04/2024',
        },
    ]);

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

    //Function to add note which is passed to AddNote component
    const handleAddNote = (text) => {
        const date = new Date();
        const newNote = {
            id: nanoid(),
            text: text,
            date: date.toLocaleDateString()
        };
        //make fetch POST request to server /api/notes 
        const newNotes = [...notes, newNote];
        setNotes(newNotes);
    }

    return (
        <div className='notes-list'>
            {notes.map((note) => <Note key={note.id} text={note.text} date={note.date} />)}
            <AddNote handleAddNote={handleAddNote}/>
        </div>     
    )
}

export default Notes;
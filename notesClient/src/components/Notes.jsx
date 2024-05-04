import React, { useEffect, useState } from 'react'
import Note from './Note';
import AddNote from './AddNote';
import Search from './Search'

const Notes = () => {
    const [notes, setNotes] = useState([]);

    const [searchText, setSearchText] = useState('');

    useEffect(() => {
        const fetchNotes = async () => {
            try {
                const response = await fetch("/api/notes");
                if (!response.ok) {
                    throw new Error(`HTTP error! status: ${response.status}`);
                }
                const data = await response.json();
                setNotes(data);
            } catch (error) {
                console.log('There was a problem with the fetch operation: ' + error.message);
            }
        }
        fetchNotes()
    }, [])

    //Function to add note which is passed to AddNote component
    const handleAddNote = async (text) => {
        const date = new Date();
        const newNote = {
            text: text,
            date: date.toISOString()
        };
        //make fetch POST request to server /api/notes 
        try {
            const response = await fetch('/api/notes', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(newNote),
            });
            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            };
            const data = await response.json();
            const newNotes = [...notes, data];
            setNotes(newNotes);
        } catch (error) {
            console.error('Error:', error);
        }
    }

    const handleDeleteNote = async (id) => {
        //make fetch DELETE to server /api/notes
        try {
            const response = await fetch(`/api/notes/${id}`, {
                method: 'DELETE',
            });
            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            };
            const newNotes = notes.filter(note => note.id !== id);
            setNotes(newNotes);
        } catch (error) {
            console.error('Error:', error);
        }
    }

    return (
        <>
            <Search handleSearchNote={setSearchText} />
            <div className='notes-list'>
                {notes
                    .filter((note) =>
                        note.text.toLowerCase().includes(searchText)
                    )
                    .map((note) =>
                        <Note
                            key={note.id}
                            id={note.id}
                            text={note.text}
                            date={note.date}
                            handleDeleteNote={handleDeleteNote}
                        />
                    )}
                <AddNote handleAddNote={handleAddNote} />
            </div>
        </>
    )
}

export default Notes;
"use client"
import "../../css/search-events.css"

const SearchEvents = () => {
    return(
        <div>
            <fieldset className={"flex justify-between"}>
                    <label htmlFor=""></label>
                    <input placeholder={"Начните вводить имя фамилию куратора"} type="search" id="site-search" name="q" className={"border-solid mb-10 mt-8 text-3xl border-2 p-1 serch-bar rounded-md mr-2"}/>
            </fieldset>
        </div>
    )
}


export default SearchEvents